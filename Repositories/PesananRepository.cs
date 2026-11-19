using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Repositories
{
    public class PesananRepository : BaseRepository
    {
        private Pesanan MapPesanan(NpgsqlDataReader reader)
        {
            var p = new Pesanan
            {
                IdPesanan = reader.GetInt32(reader.GetOrdinal("id_pesanan")),
                KodePesanan = reader.GetString(reader.GetOrdinal("kode_pesanan")),
                IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                TanggalPesanan = reader.GetDateTime(reader.GetOrdinal("tanggal_pesanan")),
                AlamatPengiriman = reader.GetString(reader.GetOrdinal("alamat_pengiriman")),
                Catatan = reader.IsDBNull(reader.GetOrdinal("catatan"))
                    ? string.Empty : reader.GetString(reader.GetOrdinal("catatan")),
                Subtotal = reader.GetDecimal(reader.GetOrdinal("subtotal")),
                Ongkir = reader.GetDecimal(reader.GetOrdinal("ongkir")),
                GrandTotal = reader.GetDecimal(reader.GetOrdinal("grand_total"))
            };

            string metodeStr = reader.GetString(reader.GetOrdinal("metode_pembayaran"));
            p.MetodePembayaran = metodeStr switch
            {
                "Transfer" => MetodePembayaran.Transfer,
                "COD" => MetodePembayaran.COD,
                "Dompet Digital" or "DompetDigital" => MetodePembayaran.DompetDigital,
                _ => MetodePembayaran.Transfer
            };

            string statusStr = reader.GetString(reader.GetOrdinal("status"));
            p.Status = Enum.TryParse<StatusPesanan>(statusStr, out var sp) ? sp : StatusPesanan.Menunggu;

            string bayarStr = reader.GetString(reader.GetOrdinal("status_pembayaran"));
            p.StatusPembayaran = bayarStr switch
            {
                "Lunas" => StatusPembayaran.Lunas,
                _ => StatusPembayaran.BelumDibayar
            };

            return p;
        }

        private DetailPesanan MapDetail(NpgsqlDataReader reader)
        {
            return new DetailPesanan
            {
                IdDetail = reader.GetInt32(reader.GetOrdinal("id_detail")),
                IdPesanan = reader.GetInt32(reader.GetOrdinal("id_pesanan")),
                IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                NamaProduk = reader.GetString(reader.GetOrdinal("nama_produk")),
                HargaSatuan = reader.GetDecimal(reader.GetOrdinal("harga_satuan")),
                Kuantitas = reader.GetInt32(reader.GetOrdinal("kuantitas")),
                Subtotal = reader.GetDecimal(reader.GetOrdinal("subtotal"))
            };
        }

        public int Add(Pesanan p, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = @"
                INSERT INTO pesanan (kode_pesanan, id_user, alamat_pengiriman,
                                     metode_pembayaran, status_pembayaran, status,
                                     catatan, subtotal, ongkir, grand_total)
                VALUES (@kode, @uid, @alamat, @metode, @status_bayar, @status,
                        @catatan, @subtotal, @ongkir, @grand_total)
                RETURNING id_pesanan";

            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@kode", p.KodePesanan);
            cmd.Parameters.AddWithValue("@uid", p.IdUser);
            cmd.Parameters.AddWithValue("@alamat", p.AlamatPengiriman);
            cmd.Parameters.AddWithValue("@metode", p.MetodePembayaran switch
            {
                MetodePembayaran.Transfer => "Transfer",
                MetodePembayaran.COD => "COD",
                MetodePembayaran.DompetDigital => "Dompet Digital",
                _ => "Transfer"
            });
            cmd.Parameters.AddWithValue("@status_bayar", p.StatusPembayaran == StatusPembayaran.Lunas ? "Lunas" : "Belum Dibayar");
            cmd.Parameters.AddWithValue("@status", p.Status.ToString());
            cmd.Parameters.AddWithValue("@catatan", (object?)p.Catatan ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@subtotal", p.Subtotal);
            cmd.Parameters.AddWithValue("@ongkir", p.Ongkir);
            cmd.Parameters.AddWithValue("@grand_total", p.GrandTotal);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int AddDetail(DetailPesanan d, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = @"
                INSERT INTO detail_pesanan (id_pesanan, id_produk, nama_produk,
                                            harga_satuan, kuantitas, subtotal)
                VALUES (@oid, @pid, @nama, @harga, @qty, @subtotal)
                RETURNING id_detail";

            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@oid", d.IdPesanan);
            cmd.Parameters.AddWithValue("@pid", d.IdProduk);
            cmd.Parameters.AddWithValue("@nama", d.NamaProduk);
            cmd.Parameters.AddWithValue("@harga", d.HargaSatuan);
            cmd.Parameters.AddWithValue("@qty", d.Kuantitas);
            cmd.Parameters.AddWithValue("@subtotal", d.Subtotal);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Pesanan> GetByUserId(int userId)
        {
            const string sql = "SELECT * FROM pesanan WHERE id_user = @uid ORDER BY tanggal_pesanan DESC";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", userId);
            var list = new List<Pesanan>();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapPesanan(reader));
            return list;
        }

        public List<Pesanan> GetAll()
        {
            const string sql = "SELECT * FROM pesanan ORDER BY tanggal_pesanan DESC";
            var list = new List<Pesanan>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapPesanan(reader));
            return list;
        }

        public Pesanan? GetById(int id)
        {
            const string sql = "SELECT * FROM pesanan WHERE id_pesanan = @id";
            using var conn = CreateConnection();
            conn.Open();

            Pesanan? pesanan = null;

            using (var cmd = CreateCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                    pesanan = MapPesanan(reader);
            }

            if (pesanan is null) return null;

            const string sqlDetails = "SELECT * FROM detail_pesanan WHERE id_pesanan = @id";
            using (var cmdDetails = CreateCommand(sqlDetails, conn))
            {
                cmdDetails.Parameters.AddWithValue("@id", id);
                using var reader = cmdDetails.ExecuteReader();
                while (reader.Read())
                    pesanan.Details.Add(MapDetail(reader));
            }

            return pesanan;
        }

        public bool UpdateStatus(int id, StatusPesanan status, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = "UPDATE pesanan SET status = @status WHERE id_pesanan = @id";
            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@status", status.ToString());
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateStatusPembayaran(int id, StatusPembayaran status, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            const string sql = "UPDATE pesanan SET status_pembayaran = @status WHERE id_pesanan = @id";
            using var cmd = new NpgsqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@status", status == StatusPembayaran.Lunas ? "Lunas" : "Belum Dibayar");
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public decimal GetTotalPendapatan()
        {
            const string sql = "SELECT COALESCE(SUM(grand_total), 0) FROM pesanan WHERE status = 'Selesai'";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public int GetCountByStatus(StatusPesanan status)
        {
            const string sql = "SELECT COUNT(*) FROM pesanan WHERE status = @status";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@status", status.ToString());
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<Pesanan> GetRecentOrders(int count = 10)
        {
            string sql = $"SELECT * FROM pesanan ORDER BY tanggal_pesanan DESC LIMIT {count}";
            var list = new List<Pesanan>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(MapPesanan(reader));
            return list;
        }

        public string GenerateKodePesanan()
        {
            string today = DateTime.Now.ToString("yyyyMMdd");
            string prefix = $"KRT-{today}-";
            const string sql = "SELECT COUNT(*) FROM pesanan WHERE kode_pesanan LIKE @pfx";

            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pfx", prefix + "%");
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return $"{prefix}{(count + 1):D3}";
        }
    }
}
