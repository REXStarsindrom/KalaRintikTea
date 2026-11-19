// ============================================================
// FILE: Helpers/AppConfig.cs
// Kala Rintik Tea - Konfigurasi Aplikasi
// ============================================================
namespace KalaRintikTea.Helpers
{
    public static class AppConfig
    {
        /// <summary>Ongkos kirim flat rate (Rp10.000).</summary>
        public const decimal OngkirFlatRate = 10_000m;

        /// <summary>Connection string PostgreSQL.</summary>
        public const string ConnectionString =
            "Host=localhost;Port=5432;Database=kalarintiktea;Username=postgres;Password=126259";

        /// <summary>Nama aplikasi.</summary>
        public const string AppName = "Kala Rintik Tea";

        /// <summary>Versi aplikasi.</summary>
        public const string AppVersion = "1.0";
    }
}
