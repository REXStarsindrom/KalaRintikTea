using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Payment
{
    public static class PaymentMethodFactory
    {
        public static IPaymentMethod Create(MetodePembayaran metode)
        {
            return metode switch
            {
                MetodePembayaran.Transfer => new TransferPayment(),
                MetodePembayaran.COD => new CodPayment(),
                MetodePembayaran.DompetDigital => new DompetDigitalPayment(),
                _ => throw new ArgumentException($"Metode pembayaran tidak dikenal: {metode}")
            };
        }
    }
}
