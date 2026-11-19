using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;

namespace KalaRintikTea.Repositories
{
    public class ProdukRepository : BaseRepository
    {
        private Produk MapProduk(NpgsqlDataReader reader)
        {
            var p = new Produk
            {
                IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                IdKategori = reader.GetInt32(reader.GetOrdinal("id_kategori")),
                Nama = reader.GetString(reader.GetOrdinal("nama")),
                Deskripsi = reader.IsDBNull(reader.GetOrdinal("deskripsi"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("deskripsi")),
                Harga = reader.GetDecimal(reader.GetOrdinal("harga")),
                BeratGram = reader.GetInt32(reader.GetOrdinal("berat_gram")),
                AsalDaerah = reader.IsDBNull(reader.GetOrdinal("asal_daerah"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("asal_daerah")),
                PathGambar = reader.IsDBNull(reader.GetOrdinal("path_gambar"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("path_gambar")),
                RataRataRating = reader.GetDecimal(reader.GetOrdinal("rata_rata_rating")),
                JumlahUlasan = reader.GetInt32(reader.GetOrdinal("jumlah_ulasan")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("is_active")),
                CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"))
            };
            p.SetStok(reader.GetInt32(reader.GetOrdinal("stok")));

            try
            {
                int katNameOrd = reader.GetOrdinal("nama_kategori");
                if (!reader.IsDBNull(katNameOrd))
                {
                    p.NamaKategori = reader.GetString(katNameOrd);
                }
            }
            catch
            {
                // In case nama_kategori is not in the select list
            }

            return p;
        }

        public List<Produk> GetAll()
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                ORDER BY p.id_produk ASC";
            return QueryList(sql);
        }

        public List<Produk> GetAllActive()
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE p.is_active = TRUE 
                ORDER BY p.id_produk ASC";
            return QueryList(sql);
        }

        public Produk? GetById(int id)
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE p.id_produk = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapProduk(reader);
            return null;
        }

        public int Add(Produk produk)
        {
            const string sql = @"
                INSERT INTO produk (id_kategori, nama, deskripsi, harga, stok, berat_gram, asal_daerah, path_gambar, is_active)
                VALUES (@id_kategori, @nama, @deskripsi, @harga, @stok, @berat_gram, @asal_daerah, @path_gambar, @is_active)
                RETURNING id_produk";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_kategori", produk.IdKategori);
            cmd.Parameters.AddWithValue("@nama", produk.Nama);
            cmd.Parameters.AddWithValue("@deskripsi", (object?)produk.Deskripsi ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@harga", produk.Harga);
            cmd.Parameters.AddWithValue("@stok", produk.Stok);
            cmd.Parameters.AddWithValue("@berat_gram", produk.BeratGram > 0 ? produk.BeratGram : 100);
            cmd.Parameters.AddWithValue("@asal_daerah", (object?)produk.AsalDaerah ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@path_gambar", (object?)produk.PathGambar ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@is_active", produk.IsActive);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Update(Produk produk)
        {
            const string sql = @"
                UPDATE produk 
                SET id_kategori = @id_kategori, nama = @nama, deskripsi = @deskripsi, 
                    harga = @harga, stok = @stok, berat_gram = @berat_gram, 
                    asal_daerah = @asal_daerah, path_gambar = @path_gambar, is_active = @is_active
                WHERE id_produk = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_kategori", produk.IdKategori);
            cmd.Parameters.AddWithValue("@nama", produk.Nama);
            cmd.Parameters.AddWithValue("@deskripsi", (object?)produk.Deskripsi ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@harga", produk.Harga);
            cmd.Parameters.AddWithValue("@stok", produk.Stok);
            cmd.Parameters.AddWithValue("@berat_gram", produk.BeratGram > 0 ? produk.BeratGram : 100);
            cmd.Parameters.AddWithValue("@asal_daerah", (object?)produk.AsalDaerah ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@path_gambar", (object?)produk.PathGambar ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@is_active", produk.IsActive);
            cmd.Parameters.AddWithValue("@id", produk.IdProduk);
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Produk> GetByKategori(int idKategori)
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE p.id_kategori = @kat AND p.is_active = TRUE 
                ORDER BY p.nama";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kat", idKategori);
            return ReadList(cmd);
        }

        public List<Produk> Search(string keyword)
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE p.is_active = TRUE 
                  AND (p.nama ILIKE @kw OR p.deskripsi ILIKE @kw OR p.asal_daerah ILIKE @kw)
                ORDER BY p.nama";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            return ReadList(cmd);
        }

        public List<Produk> GetLowStock(int threshold = 10)
        {
            const string sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE p.stok <= @threshold AND p.is_active = TRUE 
                ORDER BY p.stok ASC";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@threshold", threshold);
            return ReadList(cmd);
        }

        public bool UpdateRating(int idProduk, decimal avgRating, int count)
        {
            const string sql = @"
                UPDATE produk 
                SET rata_rata_rating = @avg, jumlah_ulasan = @count
                WHERE id_produk = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@avg", avgRating);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@id", idProduk);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool SetActive(int idProduk, bool active)
        {
            const string sql = "UPDATE produk SET is_active = @active WHERE id_produk = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@active", active);
            cmd.Parameters.AddWithValue("@id", idProduk);
            return cmd.ExecuteNonQuery() > 0;
        }

        public int GetActiveCount()
        {
            const string sql = "SELECT COUNT(*) FROM produk WHERE is_active = TRUE";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Produk> GetAllWithFilter(string? search, int? kategoriId, bool? isActive)
        {
            var sql = @"
                SELECT p.*, k.nama_kategori 
                FROM produk p 
                JOIN kategori k ON k.id_kategori = p.id_kategori 
                WHERE 1=1";
            var parameters = new List<NpgsqlParameter>();

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += " AND (p.nama ILIKE @search OR p.deskripsi ILIKE @search OR p.asal_daerah ILIKE @search)";
                parameters.Add(new NpgsqlParameter("@search", $"%{search}%"));
            }

            if (kategoriId.HasValue && kategoriId.Value > 0)
            {
                sql += " AND p.id_kategori = @kat";
                parameters.Add(new NpgsqlParameter("@kat", kategoriId.Value));
            }

            if (isActive.HasValue)
            {
                sql += " AND p.is_active = @active";
                parameters.Add(new NpgsqlParameter("@active", isActive.Value));
            }

            sql += " ORDER BY p.id_produk ASC";

            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddRange(parameters.ToArray());
            return ReadList(cmd);
        }

        public bool KurangiStokTx(int idProduk, int qty, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = @"
                UPDATE produk 
                SET stok = stok - @qty 
                WHERE id_produk = @id AND stok >= @qty";
            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@id", idProduk);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool TambahStokTx(int idProduk, int qty, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = @"
                UPDATE produk 
                SET stok = stok + @qty 
                WHERE id_produk = @id";
            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@id", idProduk);
            return cmd.ExecuteNonQuery() > 0;
        }

        private List<Produk> QueryList(string sql)
        {
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            return ReadList(cmd);
        }

        private List<Produk> ReadList(NpgsqlCommand cmd)
        {
            var list = new List<Produk>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapProduk(reader));
            return list;
        }
    }
}
