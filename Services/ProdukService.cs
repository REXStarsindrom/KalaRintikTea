using System;
using System.Collections.Generic;
using KalaRintikTea.Models;
using KalaRintikTea.Repositories;

namespace KalaRintikTea.Services
{
    public class ProdukService
    {
        private readonly ProdukRepository _produkRepo;
        private readonly KategoriRepository _kategoriRepo;

        public ProdukService(ProdukRepository? produkRepo = null, KategoriRepository? kategoriRepo = null)
        {
            _produkRepo = produkRepo ?? new ProdukRepository();
            _kategoriRepo = kategoriRepo ?? new KategoriRepository();
        }

        public List<Produk> GetAll()
        {
            return _produkRepo.GetAll();
        }

        public List<Produk> GetAllActive()
        {
            return _produkRepo.GetAllActive();
        }

        public Produk? GetById(int id)
        {
            return _produkRepo.GetById(id);
        }

        public List<Produk> GetByKategori(int idKategori)
        {
            return _produkRepo.GetByKategori(idKategori);
        }

        public List<Produk> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllActive();

            return _produkRepo.Search(keyword.Trim());
        }

        public List<Kategori> GetKategoriList()
        {
            return _kategoriRepo.GetAll();
        }

        public int AddProduk(Produk p)
        {
            if (string.IsNullOrWhiteSpace(p.Nama))
                throw new ArgumentException("Nama produk wajib diisi.");
            if (p.Harga <= 0)
                throw new ArgumentException("Harga harus lebih dari 0.");
            if (p.BeratGram <= 0)
                p.BeratGram = 100;

            return _produkRepo.Add(p);
        }

        public bool UpdateProduk(Produk p)
        {
            if (string.IsNullOrWhiteSpace(p.Nama))
                throw new ArgumentException("Nama produk wajib diisi.");
            if (p.Harga <= 0)
                throw new ArgumentException("Harga harus lebih dari 0.");
            if (p.BeratGram <= 0)
                p.BeratGram = 100;

            return _produkRepo.Update(p);
        }

        public bool SetActive(int idProduk, bool active)
        {
            return _produkRepo.SetActive(idProduk, active);
        }

        public List<Produk> GetLowStock(int threshold = 10)
        {
            return _produkRepo.GetLowStock(threshold);
        }

        public int GetActiveCount()
        {
            return _produkRepo.GetActiveCount();
        }

        public List<Produk> GetAllWithFilter(string? search, int? kategoriId, bool? isActive)
        {
            return _produkRepo.GetAllWithFilter(search, kategoriId, isActive);
        }
    }
}
