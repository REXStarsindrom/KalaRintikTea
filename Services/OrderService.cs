using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Repositories;
using KalaRintikTea.Shipping;

namespace KalaRintikTea.Services
{
    public class OrderService
    {
        private readonly PesananRepository _pesananRepo;
        private readonly KeranjangRepository _keranjangRepo;
        private readonly ProdukRepository _produkRepo;

        public OrderService(
            PesananRepository? pesananRepo = null,
            KeranjangRepository? keranjangRepo = null,
            ProdukRepository? produkRepo = null)
        {
            _pesananRepo = pesananRepo ?? new PesananRepository();
            _keranjangRepo = keranjangRepo ?? new KeranjangRepository();
            _produkRepo = produkRepo ?? new ProdukRepository();
        }

        public Pesanan Checkout(
            int userId,
            string alamatPengiriman,
            MetodePembayaran metodePembayaran,
            string catatan,
            IShippingCalculator shippingCalculator)
        {
            if (string.IsNullOrWhiteSpace(alamatPengiriman))
                throw new ArgumentException("Alamat pengiriman wajib diisi.");

            var cart = _keranjangRepo.GetByUserId(userId);
            if (cart == null || cart.Items.Count == 0)
                throw new InvalidOperationException("Keranjang belanja kosong.");


            decimal subtotal = 0m;
            int totalBerat = 0;
            foreach (var item in cart.Items)
            {
                if (item.Produk == null || item.Produk.Stok < item.Kuantitas)
                    throw new InvalidOperationException($"Stok produk '{item.Produk?.Nama ?? "Item"}' tidak mencukupi untuk jumlah pesanan.");

                subtotal += item.Produk.Harga * item.Kuantitas;
                totalBerat += item.Produk.BeratGram * item.Kuantitas;
            }

            decimal ongkir = shippingCalculator.Hitung(totalBerat);
            decimal grandTotal = subtotal + ongkir;


            string kodePesanan = _pesananRepo.GenerateKodePesanan();

            var pesanan = new Pesanan
            {
                KodePesanan = kodePesanan,
                IdUser = userId,
                TanggalPesanan = DateTime.Now,
                AlamatPengiriman = alamatPengiriman.Trim(),
                MetodePembayaran = metodePembayaran,
                StatusPembayaran = StatusPembayaran.BelumDibayar,
                Status = StatusPesanan.Menunggu,
                Catatan = catatan?.Trim() ?? string.Empty,
                Subtotal = subtotal,
                Ongkir = ongkir,
                GrandTotal = grandTotal
            };


            using var conn = DbConnectionFactory.CreateConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {

                int idPesanan = _pesananRepo.Add(pesanan, conn, tx);
                pesanan.IdPesanan = idPesanan;


                foreach (var item in cart.Items)
                {
                    var detail = new DetailPesanan
                    {
                        IdPesanan = idPesanan,
                        IdProduk = item.IdProduk,
                        NamaProduk = item.Produk.Nama,
                        HargaSatuan = item.Produk.Harga,
                        Kuantitas = item.Kuantitas,
                        Subtotal = item.Produk.Harga * item.Kuantitas
                    };

                    _pesananRepo.AddDetail(detail, conn, tx);
                    pesanan.Details.Add(detail);


                    bool stokUpdated = _produkRepo.KurangiStokTx(item.IdProduk, item.Kuantitas, conn, tx);
                    if (!stokUpdated)
                        throw new InvalidOperationException($"Gagal mengurangi stok produk: {item.Produk.Nama}. Stok mungkin telah berubah.");
                }


                _keranjangRepo.ClearCartTx(cart.IdKeranjang, conn, tx);


                tx.Commit();
                return pesanan;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        public bool UpdateStatus(int idPesanan, StatusPesanan statusBaru)
        {
            var pesanan = _pesananRepo.GetById(idPesanan);
            if (pesanan == null)
                throw new KeyNotFoundException("Pesanan tidak ditemukan.");


            if (statusBaru == StatusPesanan.Dibatalkan)
            {
                if (pesanan.Status == StatusPesanan.Selesai || pesanan.Status == StatusPesanan.Dibatalkan)
                    throw new InvalidOperationException($"Pesanan dengan status '{pesanan.Status}' tidak dapat dibatalkan.");


                using var conn = DbConnectionFactory.CreateConnection();
                conn.Open();
                using var tx = conn.BeginTransaction();

                try
                {
                    _pesananRepo.UpdateStatus(idPesanan, StatusPesanan.Dibatalkan, conn, tx);

                    foreach (var d in pesanan.Details)
                    {
                        _produkRepo.TambahStokTx(d.IdProduk, d.Kuantitas, conn, tx);
                    }

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
            else
            {

                bool valid = (pesanan.Status == StatusPesanan.Menunggu && statusBaru == StatusPesanan.Diproses) ||
                             (pesanan.Status == StatusPesanan.Diproses && statusBaru == StatusPesanan.Dikirim) ||
                             (pesanan.Status == StatusPesanan.Dikirim && statusBaru == StatusPesanan.Selesai);

                if (!valid)
                    throw new InvalidOperationException($"Transisi status dari '{pesanan.Status}' ke '{statusBaru}' tidak diperbolehkan.");

                using var conn = DbConnectionFactory.CreateConnection();
                conn.Open();
                using var tx = conn.BeginTransaction();

                try
                {
                    _pesananRepo.UpdateStatus(idPesanan, statusBaru, conn, tx);


                    if (statusBaru == StatusPesanan.Selesai)
                    {
                        _pesananRepo.UpdateStatusPembayaran(idPesanan, StatusPembayaran.Lunas, conn, tx);
                    }

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public List<Pesanan> GetOrdersByUser(int userId)
        {
            return _pesananRepo.GetByUserId(userId);
        }

        public List<Pesanan> GetAllOrders()
        {
            return _pesananRepo.GetAll();
        }

        public Pesanan? GetOrderById(int id)
        {
            return _pesananRepo.GetById(id);
        }

        public decimal GetTotalPendapatan()
        {
            return _pesananRepo.GetTotalPendapatan();
        }

        public int GetCountByStatus(StatusPesanan status)
        {
            return _pesananRepo.GetCountByStatus(status);
        }

        public List<Pesanan> GetRecentOrders(int count = 10)
        {
            return _pesananRepo.GetRecentOrders(count);
        }
    }
}
