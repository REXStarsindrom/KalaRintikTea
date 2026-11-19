namespace KalaRintikTea.Models
{
    public class ItemKeranjang
    {
        public int IdItem { get; set; }
        public int IdKeranjang { get; set; }
        public int IdProduk { get; set; }
        public int Kuantitas { get; set; }

        // Navigation property
        public Produk Produk { get; set; } = new Produk();

        public ItemKeranjang() { }
    }
}
