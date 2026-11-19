using System;

namespace KalaRintikTea.Models
{
    public class Kategori
    {
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; } = string.Empty;

        public Kategori() { }

        public Kategori(int idKategori, string namaKategori)
        {
            IdKategori = idKategori;
            NamaKategori = namaKategori;
        }

        public override string ToString() => NamaKategori;
    }
}
