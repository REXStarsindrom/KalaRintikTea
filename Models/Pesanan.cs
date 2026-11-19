using System;
using System.Collections.Generic;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Models
{
    public class Pesanan
    {
        public int IdPesanan { get; set; }
        public string KodePesanan { get; set; } = string.Empty;
        public int IdUser { get; set; }
        public DateTime TanggalPesanan { get; set; } = DateTime.Now;
        public string AlamatPengiriman { get; set; } = string.Empty;
        public MetodePembayaran MetodePembayaran { get; set; }
        public StatusPembayaran StatusPembayaran { get; set; }
        public StatusPesanan Status { get; set; }
        public string Catatan { get; set; } = string.Empty;
        public decimal Subtotal { get; set; }
        public decimal Ongkir { get; set; }
        public decimal GrandTotal { get; set; }
        public List<DetailPesanan> Details { get; set; } = new List<DetailPesanan>();

        public Pesanan() { }
    }
}
