using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;

namespace KalaRintikTea.Repositories
{
    public class KeranjangRepository : BaseRepository
    {
        public Keranjang? GetByUserId(int userId)
        {
            const string sqlCart = "SELECT * FROM keranjang WHERE id_user = @uid";
            using var conn = CreateConnection();
            conn.Open();

            Keranjang? keranjang = null;

            using (var cmd = CreateCommand(sqlCart, conn))
            {
                cmd.Parameters.AddWithValue("@uid", userId);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    keranjang = new Keranjang
                    {
                        IdKeranjang = reader.GetInt32(reader.GetOrdinal("id_keranjang")),
                        IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                        UpdatedAt = reader.GetDateTime(reader.GetOrdinal("updated_at"))
                    };
                }
            }

            if (keranjang == null) return null;

            // Load items with product info
            const string sqlItems = @"
                SELECT ik.id_item, ik.id_keranjang, ik.id_produk, ik.kuantitas,
                       p.nama, p.harga, p.stok, p.berat_gram, p.path_gambar, p.id_kategori
                FROM item_keranjang ik
                JOIN produk p ON p.id_produk = ik.id_produk
                WHERE ik.id_keranjang = @kid
                ORDER BY ik.id_item";

            using (var cmdItems = CreateCommand(sqlItems, conn))
            {
                cmdItems.Parameters.AddWithValue("@kid", keranjang.IdKeranjang);
                using var reader = cmdItems.ExecuteReader();
                while (reader.Read())
                {
                    var prod = new Produk
                    {
                        IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                        Nama = reader.GetString(reader.GetOrdinal("nama")),
                        Harga = reader.GetDecimal(reader.GetOrdinal("harga")),
                        BeratGram = reader.GetInt32(reader.GetOrdinal("berat_gram")),
                        IdKategori = reader.GetInt32(reader.GetOrdinal("id_kategori")),
                        PathGambar = reader.IsDBNull(reader.GetOrdinal("path_gambar"))
                            ? string.Empty : reader.GetString(reader.GetOrdinal("path_gambar"))
                    };
                    prod.SetStok(reader.GetInt32(reader.GetOrdinal("stok")));

                    var item = new ItemKeranjang
                    {
                        IdItem = reader.GetInt32(reader.GetOrdinal("id_item")),
                        IdKeranjang = reader.GetInt32(reader.GetOrdinal("id_keranjang")),
                        IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                        Kuantitas = reader.GetInt32(reader.GetOrdinal("kuantitas")),
                        Produk = prod
                    };
                    keranjang.Items.Add(item);
                }
            }

            return keranjang;
        }

        public Keranjang CreateForUser(int userId)
        {
            const string sql = @"
                INSERT INTO keranjang (id_user)
                VALUES (@uid)
                ON CONFLICT (id_user) DO UPDATE SET updated_at = NOW()
                RETURNING id_keranjang";

            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", userId);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return new Keranjang
            {
                IdKeranjang = id,
                IdUser = userId,
                UpdatedAt = DateTime.Now
            };
        }

        public bool AddItem(int idKeranjang, int idProduk, int qty)
        {
            const string sql = @"
                INSERT INTO item_keranjang (id_keranjang, id_produk, kuantitas)
                VALUES (@kid, @pid, @qty)
                ON CONFLICT (id_keranjang, id_produk)
                DO UPDATE SET kuantitas = item_keranjang.kuantitas + EXCLUDED.kuantitas";

            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kid", idKeranjang);
            cmd.Parameters.AddWithValue("@pid", idProduk);
            cmd.Parameters.AddWithValue("@qty", qty);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateItemQty(int idItem, int qty)
        {
            const string sql = "UPDATE item_keranjang SET kuantitas = @qty WHERE id_item = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@id", idItem);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool RemoveItem(int idItem)
        {
            const string sql = "DELETE FROM item_keranjang WHERE id_item = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idItem);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool ClearCart(int idKeranjang)
        {
            const string sql = "DELETE FROM item_keranjang WHERE id_keranjang = @kid";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kid", idKeranjang);
            return cmd.ExecuteNonQuery() >= 0;
        }

        public bool ClearCartTx(int idKeranjang, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = "DELETE FROM item_keranjang WHERE id_keranjang = @kid";
            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@kid", idKeranjang);
            return cmd.ExecuteNonQuery() >= 0;
        }
    }
}
