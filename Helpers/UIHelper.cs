using System;
using System.Drawing;
using System.Windows.Forms;

namespace KalaRintikTea.Helpers
{
    public static class UIHelper
    {
        // Palette sesuai Mockup Desain Kala Rintik Tea
        public static readonly Color HijauUtama     = Color.FromArgb(27, 94, 59);     // #1B5E3B Dark Green
        public static readonly Color HijauHover     = Color.FromArgb(20, 70, 44);     // Darker Green for hover
        public static readonly Color LatarKrem      = Color.FromArgb(253, 245, 236);  // #FDF5EC Cream Warm Beige
        public static readonly Color Putih          = Color.White;
        public static readonly Color TeksUtama      = Color.FromArgb(40, 40, 40);     // #282828
        public static readonly Color TeksSekunder   = Color.FromArgb(115, 115, 115);  // #737373
        public static readonly Color BorderHalus    = Color.FromArgb(225, 225, 225);
        public static readonly Color HijauBadge     = Color.FromArgb(232, 245, 233);  // Soft green badge
        public static readonly Color KuningStatus   = Color.FromArgb(254, 243, 199);  // Menunggu
        public static readonly Color BiruStatus     = Color.FromArgb(224, 231, 255);  // Diproses
        public static readonly Color OranyeStatus   = Color.FromArgb(254, 237, 213);  // Dikirim
        public static readonly Color HijauStatus    = Color.FromArgb(220, 252, 231);  // Selesai
        public static readonly Color MerahStatus    = Color.FromArgb(254, 226, 226);  // Dibatalkan

        public static Button BuatTombol(string teks, Color warnaBg, Color warnaFont, int lebar = 140, int tinggi = 40)
        {
            var btn = new Button
            {
                Text = teks,
                BackColor = warnaBg,
                ForeColor = warnaFont,
                FlatStyle = FlatStyle.Flat,
                Width = lebar,
                Height = tinggi,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        public static Panel BuatBadge(string text, Color bg, Color fg)
        {
            var panel = new Panel
            {
                BackColor = bg,
                AutoSize = true,
                Padding = new Padding(8, 4, 8, 4)
            };
            var lbl = new Label
            {
                Text = text,
                ForeColor = fg,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(lbl);
            return panel;
        }

        public static string FormatRupiah(decimal nominal)
        {
            return $"Rp{nominal:N0}".Replace(",", ".");
        }
    }
}
