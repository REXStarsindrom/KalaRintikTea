using System;

namespace KalaRintikTea.Models
{
    public class Ulasan
    {
        public int IdUlasan { get; set; }
        public int IdUser { get; set; }
        public int IdProduk { get; set; }
        public int IdPesanan { get; set; }

        private int _rating = 5;
        public int Rating
        {
            get => _rating;
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentOutOfRangeException(nameof(Rating), "Rating harus antara 1 dan 5.");
                _rating = value;
            }
        }

        public string Komentar { get; set; } = string.Empty;
        public DateTime Tanggal { get; set; } = DateTime.Now;

        // Display properties
        public string NamaUser { get; set; } = string.Empty;
        public string NamaProduk { get; set; } = string.Empty;

        public Ulasan() { }
    }
}
