using KalaRintikTea.Models;

namespace KalaRintikTea.Payment
{
    public class CodPayment : IPaymentMethod
    {
        public string BuatInstruksi(Pesanan pesanan)
        {
            return $"Pembayaran COD (Cash on Delivery)\n" +
                   $"Kode Pesanan: {pesanan.KodePesanan}\n" +
                   $"Total yang harus dibayar: Rp{pesanan.GrandTotal:N0}\n\n" +
                   $"Siapkan uang pas saat kurir tiba di alamat Anda.\n" +
                   $"Alamat pengiriman: {pesanan.AlamatPengiriman}";
        }
    }
}
