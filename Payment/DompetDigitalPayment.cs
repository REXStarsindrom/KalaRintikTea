using KalaRintikTea.Models;

namespace KalaRintikTea.Payment
{
    public class DompetDigitalPayment : IPaymentMethod
    {
        public string BuatInstruksi(Pesanan pesanan)
        {
            return $"Pembayaran via Dompet Digital\n" +
                   $"Kode Pesanan: {pesanan.KodePesanan}\n" +
                   $"Total: Rp{pesanan.GrandTotal:N0}\n\n" +
                   $"Silakan transfer ke salah satu akun berikut:\n" +
                   $"- GoPay: 081234567890\n" +
                   $"- OVO: 081234567890\n" +
                   $"- DANA: 081234567890\n\n" +
                   $"Harap sertakan kode pesanan pada catatan pembayaran.";
        }
    }
}
