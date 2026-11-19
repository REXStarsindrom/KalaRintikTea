using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;

namespace KalaRintikTea.Repositories
{
    public class UlasanRepository : BaseRepository
    {
        public int Add(Ulasan u)
        {
            const string sql = @"
                INSERT INTO ulasan (id_user, id_produk, id_pesanan, rating, komentar)
                VALUES (@uid, @pid, @oid, @rating, @komentar)
                RETURNING id_ulasan";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", u.IdUser);
            cmd.Parameters.AddWithValue("@pid", u.IdProduk);
            cmd.Parameters.AddWithValue("@oid", u.IdPesanan);
            cmd.Parameters.AddWithValue("@rating", u.Rating);
            cmd.Parameters.AddWithValue("@komentar", (object?)u.Komentar ?? DBNull.Value);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Ulasan> GetByProduk(int idProduk)
        {
            const string sql = @"
                SELECT ul.*, u.nama AS nama_user, p.nama AS nama_produk
                FROM ulasan ul
                JOIN users u ON u.id_user = ul.id_user
                JOIN produk p ON p.id_produk = ul.id_produk
                WHERE ul.id_produk = @pid
                ORDER BY ul.tanggal DESC";

            var list = new List<Ulasan>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", idProduk);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapUlasan(reader));
            return list;
        }

        public List<Ulasan> GetByUser(int userId)
        {
            const string sql = @"
                SELECT ul.*, u.nama AS nama_user, p.nama AS nama_produk
                FROM ulasan ul
                JOIN users u ON u.id_user = ul.id_user
                JOIN produk p ON p.id_produk = ul.id_produk
                WHERE ul.id_user = @uid
                ORDER BY ul.tanggal DESC";

            var list = new List<Ulasan>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", userId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapUlasan(reader));
            return list;
        }

        public bool HasReviewed(int userId, int idProduk)
        {
            const string sql = "SELECT COUNT(1) FROM ulasan WHERE id_user = @uid AND id_produk = @pid";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", userId);
            cmd.Parameters.AddWithValue("@pid", idProduk);
            return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
        }

        public List<Ulasan> GetRecentReviews(int count = 5)
        {
            string sql = $@"
                SELECT ul.*, u.nama AS nama_user, p.nama AS nama_produk
                FROM ulasan ul
                JOIN users u ON u.id_user = ul.id_user
                JOIN produk p ON p.id_produk = ul.id_produk
                ORDER BY ul.tanggal DESC
                LIMIT {count}";

            var list = new List<Ulasan>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapUlasan(reader));
            return list;
        }

        public (decimal AverageRating, int Count) GetAverageRating(int idProduk)
        {
            const string sql = @"
                SELECT COALESCE(AVG(rating), 0) AS avg_rating, COUNT(1) AS count_rating
                FROM ulasan
                WHERE id_produk = @pid";

            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", idProduk);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                decimal avg = Convert.ToDecimal(reader["avg_rating"]);
                int count = Convert.ToInt32(reader["count_rating"]);
                return (avg, count);
            }
            return (0m, 0);
        }

        private Ulasan MapUlasan(NpgsqlDataReader reader)
        {
            return new Ulasan
            {
                IdUlasan = reader.GetInt32(reader.GetOrdinal("id_ulasan")),
                IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                IdPesanan = reader.GetInt32(reader.GetOrdinal("id_pesanan")),
                Rating = reader.GetInt32(reader.GetOrdinal("rating")),
                Komentar = reader.IsDBNull(reader.GetOrdinal("komentar"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("komentar")),
                Tanggal = reader.GetDateTime(reader.GetOrdinal("tanggal")),
                NamaUser = reader.IsDBNull(reader.GetOrdinal("nama_user"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("nama_user")),
                NamaProduk = reader.IsDBNull(reader.GetOrdinal("nama_produk"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("nama_produk"))
            };
        }
    }
}
