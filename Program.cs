using System;
using System.Windows.Forms;
using KalaRintikTea.Database;
using KalaRintikTea.Forms;

namespace KalaRintikTea
{
    internal static class Program
    {
        
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();


            bool dbSuccess = DbInitializer.Initialize(out string errorMessage);
            if (!dbSuccess)
            {
                
                MessageBox.Show(
                    "Catatan Koneksi Basis Data:\n" +
                    "Aplikasi belum dapat terhubung ke PostgreSQL lokal di 'localhost:5432'.\n\n" +
                    "Detail Error: " + errorMessage + "\n\n" +
                    "Pastikan PostgreSQL aktif dengan nama database 'kalarintiktea' dan konfigurasi di AppConfig.cs jika ingin menjalankan fitur transaksi lengkap.",
                    "Informasi Koneksi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            Application.Run(new FormLanding());
        }
    }
}
