using System;
using System.Linq;
using KalaRintikTea.Models;
using KalaRintikTea.Repositories;

namespace KalaRintikTea.Services
{
    public class CartService
    {
        private readonly KeranjangRepository _keranjangRepo;
        private readonly ProdukRepository _produkRepo;

        public CartService(KeranjangRepository? keranjangRepo = null, ProdukRepository? produkRepo = null)
        {
            _keranjangRepo = keranjangRepo ?? new KeranjangRepository();
            _produkRepo = produkRepo ?? new ProdukRepository();
        }

        public Keranjang GetCart(int userId)
        {
            var cart = _keranjangRepo.GetByUserId(userId);
            if (cart == null)
            {
                cart = _keranjangRepo.CreateForUser(userId);
            }
            return cart;
        }

        public bool AddToCart(int userId, int idProduk, int qty)
        {
            if (qty <= 0)
                throw new ArgumentException("Kuantitas harus lebih dari 0.");

            var produk = _produkRepo.GetById(idProduk);
            if (produk == null || !produk.IsActive)
                throw new InvalidOperationException("Produk tidak ditemukan atau sudah tidak aktif.");

            var cart = GetCart(userId);
            var existingItem = cart.Items.FirstOrDefault(i => i.IdProduk == idProduk);
            int currentInCart = existingItem?.Kuantitas ?? 0;

            if (currentInCart + qty > produk.Stok)
                throw new InvalidOperationException($"Stok tidak mencukupi. Tersedia: {produk.Stok}, di keranjang: {currentInCart}.");

            return _keranjangRepo.AddItem(cart.IdKeranjang, idProduk, qty);
        }

        public bool UpdateQty(int idItem, int qty)
        {
            if (qty <= 0)
                return RemoveItem(idItem);

            return _keranjangRepo.UpdateItemQty(idItem, qty);
        }

        public bool RemoveItem(int idItem)
        {
            return _keranjangRepo.RemoveItem(idItem);
        }

        public bool ClearCart(int userId)
        {
            var cart = _keranjangRepo.GetByUserId(userId);
            if (cart == null) return true;
            return _keranjangRepo.ClearCart(cart.IdKeranjang);
        }

        public decimal GetSubtotal(Keranjang cart)
        {
            if (cart?.Items == null) return 0m;
            return cart.Items.Sum(i => (i.Produk?.Harga ?? 0m) * i.Kuantitas);
        }

        public int GetTotalBerat(Keranjang cart)
        {
            if (cart?.Items == null) return 0;
            return cart.Items.Sum(i => (i.Produk?.BeratGram ?? 100) * i.Kuantitas);
        }

        public int GetItemCount(int userId)
        {
            var cart = _keranjangRepo.GetByUserId(userId);
            return cart?.Items?.Sum(i => i.Kuantitas) ?? 0;
        }
    }
}
