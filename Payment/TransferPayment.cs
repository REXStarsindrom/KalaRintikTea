using KalaRintikTea.Models;

namespace KalaRintikTea.Payment
{
    public class TransferPayment : IPaymentMethod
    {
        public string BuatInstruksi(Pesanan pesanan)
        {
            return $"Silakan transfer sejumlah Rp{pesanan.GrandTotal:N0} ke rekening berikut:\n" +
                   $"Bank: BCA\n" +
                   $"No. Rekening: 1234567890\n" +
                   $"Atas Nama: Kala Rintik Tea\n" +
                   $"Kode Pesanan: {pesanan.KodePesanan}\n\n" +
                   $"Harap sertakan kode pesanan pada berita transfer.";
        }
    }
}
