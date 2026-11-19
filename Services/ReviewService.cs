using System;
using System.Collections.Generic;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Repositories;

namespace KalaRintikTea.Services
{
    public class ReviewService
    {
        private readonly UlasanRepository _ulasanRepo;
        private readonly ProdukRepository _produkRepo;
        private readonly PesananRepository _pesananRepo;

        public ReviewService(
            UlasanRepository? ulasanRepo = null,
            ProdukRepository? produkRepo = null,
            PesananRepository? pesananRepo = null)
        {
            _ulasanRepo = ulasanRepo ?? new UlasanRepository();
            _produkRepo = produkRepo ?? new ProdukRepository();
            _pesananRepo = pesananRepo ?? new PesananRepository();
        }

        public bool CanReview(int userId, int idProduk, int idPesanan)
        {

            var pesanan = _pesananRepo.GetById(idPesanan);
            if (pesanan == null || pesanan.Status != StatusPesanan.Selesai || pesanan.IdUser != userId)
                return false;


            return !_ulasanRepo.HasReviewed(userId, idProduk);
        }

        public int AddReview(Ulasan ulasan)
        {
            if (ulasan.Rating < 1 || ulasan.Rating > 5)
                throw new ArgumentOutOfRangeException(nameof(ulasan.Rating), "Rating harus bernilai 1 sampai 5.");

            if (_ulasanRepo.HasReviewed(ulasan.IdUser, ulasan.IdProduk))
                throw new InvalidOperationException("Anda sudah memberikan ulasan untuk produk ini.");

            var pesanan = _pesananRepo.GetById(ulasan.IdPesanan);
            if (pesanan == null || pesanan.Status != StatusPesanan.Selesai)
                throw new InvalidOperationException("Ulasan hanya dapat diberikan untuk pesanan yang telah selesai.");

            int id = _ulasanRepo.Add(ulasan);


            var (avg, count) = _ulasanRepo.GetAverageRating(ulasan.IdProduk);
            _produkRepo.UpdateRating(ulasan.IdProduk, Math.Round(avg, 2), count);

            return id;
        }

        public List<Ulasan> GetByProduk(int idProduk)
        {
            return _ulasanRepo.GetByProduk(idProduk);
        }

        public List<Ulasan> GetByUser(int userId)
        {
            return _ulasanRepo.GetByUser(userId);
        }

        public List<Ulasan> GetRecentReviews(int count = 5)
        {
            return _ulasanRepo.GetRecentReviews(count);
        }
    }
}
