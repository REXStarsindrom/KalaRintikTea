using System;

namespace KalaRintikTea.Models
{
    public class Produk
    {
        public int IdProduk { get; set; }
        public int IdKategori { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Deskripsi { get; set; } = string.Empty;
        public decimal Harga { get; set; }

        private int _stok;
        public int Stok => _stok;

        public int BeratGram { get; set; }
        public string AsalDaerah { get; set; } = string.Empty;
        public string PathGambar { get; set; } = string.Empty;
        public decimal RataRataRating { get; set; }
        public int JumlahUlasan { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation / helper property
        public string NamaKategori { get; set; } = string.Empty;

        public Produk() { }

        public void SetStok(int stok)
        {
            _stok = Math.Max(0, stok);
        }

        public bool CukupStok(int qty)
        {
            return _stok >= qty;
        }

        public void KurangiStok(int qty)
        {
            if (qty <= 0)
                throw new ArgumentException("Jumlah pengurangan stok harus lebih dari 0.");
            if (qty > _stok)
                throw new InvalidOperationException("Stok tidak mencukupi.");
            _stok -= qty;
        }

        public void TambahStok(int qty)
        {
            if (qty <= 0)
                throw new ArgumentException("Jumlah penambahan stok harus lebih dari 0.");
            _stok += qty;
        }

        public void Nonaktifkan()
        {
            IsActive = false;
        }
    }
}
