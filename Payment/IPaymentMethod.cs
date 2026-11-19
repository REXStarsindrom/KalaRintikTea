using KalaRintikTea.Models;

namespace KalaRintikTea.Payment
{
    public interface IPaymentMethod
    {
        string BuatInstruksi(Pesanan pesanan);
    }
}
