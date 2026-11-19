namespace KalaRintikTea.Models
{
    public class DetailPesanan
    {
        public int IdDetail { get; set; }
        public int IdPesanan { get; set; }
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; } = string.Empty;
        public decimal HargaSatuan { get; set; }
        public int Kuantitas { get; set; }
        public decimal Subtotal { get; set; }

        public DetailPesanan() { }
    }
}
