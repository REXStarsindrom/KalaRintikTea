using KalaRintikTea.Helpers;

namespace KalaRintikTea.Shipping
{
    public class FlatRateShippingCalculator : IShippingCalculator
    {
        public decimal Hitung(int totalBeratGram)
        {
            return AppConfig.OngkirFlatRate;
        }
    }
}
