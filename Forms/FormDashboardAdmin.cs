using System;
using System.Drawing;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormDashboardAdmin : BaseForm
    {
        private readonly OrderService _orderService;
        private readonly ProdukService _produkService;
        private readonly ReviewService _reviewService;

        public FormDashboardAdmin()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _produkService = new ProdukService();
            _reviewService = new ReviewService();

            SetupSidebar();
            InitRecentOrdersGrid();
            LoadDashboardData();

            btnNavDataBarang.Click += (s, e) => NavigateTo(this, new FormManajemenProduk());
            btnNavTransaksi.Click += (s, e) => NavigateTo(this, new FormTransaksiAdmin());
            btnNavPelanggan.Click += (s, e) => NavigateTo(this, new FormPelangganAdmin());
            btnNavUlasan.Click += (s, e) => NavigateTo(this, new FormUlasanAdmin());
            btnKeluar.Click += (s, e) =>
            {
                if (Confirm("Apakah Anda yakin ingin keluar dari panel admin?", "Konfirmasi Keluar"))
                {
                    SessionManager.Instance.Logout();
                    NavigateTo(this, new FormLanding());
                }
            };
        }

        private void SetupSidebar()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user != null)
            {
                lblUserName.Text = user.Nama;
                lblAvatar.Text = user.Nama.Length > 0 ? user.Nama.Substring(0, 1).ToUpper() : "A";
                lblSubtitle.Text = $"Ringkasan toko hari ini · {DateTime.Now:dddd, d MMMM yyyy}";
            }
        }

        private void InitRecentOrdersGrid()
        {
            dgvRecentOrders.Columns.Clear();
            dgvRecentOrders.Columns.Add("KodePesanan", "Kode Pesanan");
            dgvRecentOrders.Columns.Add("Tanggal", "Tanggal");
            dgvRecentOrders.Columns.Add("Total", "Total");
            dgvRecentOrders.Columns.Add("Status", "Status");

            dgvRecentOrders.Columns["KodePesanan"].FillWeight = 35;
            dgvRecentOrders.Columns["Tanggal"].FillWeight = 25;
            dgvRecentOrders.Columns["Total"].FillWeight = 20;
            dgvRecentOrders.Columns["Status"].FillWeight = 20;
        }

        private void LoadDashboardData()
        {
            try
            {
                // 1. Stat cards
                decimal totalPendapatan = _orderService.GetTotalPendapatan();
                lblStat1Value.Text = UIHelper.FormatRupiah(totalPendapatan);

                int countMenunggu = _orderService.GetCountByStatus(StatusPesanan.Menunggu);
                int countDiproses = _orderService.GetCountByStatus(StatusPesanan.Diproses);
                int countDikirim = _orderService.GetCountByStatus(StatusPesanan.Dikirim);
                int countSelesai = _orderService.GetCountByStatus(StatusPesanan.Selesai);
                int countDibatalkan = _orderService.GetCountByStatus(StatusPesanan.Dibatalkan);
                int totalPesanan = countMenunggu + countDiproses + countDikirim + countSelesai + countDibatalkan;

                lblStat2Value.Text = totalPesanan.ToString();
                lblStat2Sub.Text = $"{countMenunggu} menunggu diproses";

                int produkAktif = _produkService.GetActiveCount();
                lblStat3Value.Text = produkAktif.ToString();

                int perluTindakLanjut = countMenunggu + countDiproses;
                lblStat4Value.Text = perluTindakLanjut.ToString();

                // 2. Status counts pills
                lblCountMenunggu.Text = $"Menunggu: {countMenunggu}";
                lblCountDiproses.Text = $"Diproses: {countDiproses}";
                lblCountDikirim.Text = $"Dikirim: {countDikirim}";
                lblCountSelesai.Text = $"Selesai: {countSelesai}";
                lblCountDibatalkan.Text = $"Dibatalkan: {countDibatalkan}";

                // 3. Low stock warning
                flowLowStock.Controls.Clear();
                var lowStockList = _produkService.GetLowStock(10);
                if (lowStockList.Count == 0)
                {
                    flowLowStock.Controls.Add(new Label
                    {
                        Text = "Semua stok produk aman (di atas 10 unit).",
                        ForeColor = UIHelper.HijauUtama,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9f)
                    });
                }
                else
                {
                    foreach (var p in lowStockList)
                    {
                        var lbl = new Label
                        {
                            Text = $"• {p.Nama}  (Sisa {p.Stok})",
                            ForeColor = p.Stok <= 3 ? Color.Red : Color.FromArgb(180, 80, 0),
                            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                            AutoSize = true,
                            Margin = new Padding(0, 0, 0, 4)
                        };
                        flowLowStock.Controls.Add(lbl);
                    }
                }

                // 4. Recent Orders
                dgvRecentOrders.Rows.Clear();
                var recentOrders = _orderService.GetRecentOrders(6);
                foreach (var p in recentOrders)
                {
                    int rIdx = dgvRecentOrders.Rows.Add(
                        p.KodePesanan,
                        p.TanggalPesanan.ToString("dd MMM, HH:mm"),
                        UIHelper.FormatRupiah(p.GrandTotal),
                        p.Status.ToString()
                    );
                    var cell = dgvRecentOrders.Rows[rIdx].Cells["Status"];
                    cell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                    cell.Style.ForeColor = p.Status switch
                    {
                        StatusPesanan.Menunggu => Color.FromArgb(180, 110, 0),
                        StatusPesanan.Diproses => Color.FromArgb(30, 80, 190),
                        StatusPesanan.Dikirim => Color.FromArgb(200, 90, 0),
                        StatusPesanan.Selesai => Color.FromArgb(27, 94, 59),
                        StatusPesanan.Dibatalkan => Color.FromArgb(190, 30, 30),
                        _ => Color.Black
                    };
                }

                // 5. Recent Reviews
                flowRecentReviews.Controls.Clear();
                var recentReviews = _reviewService.GetRecentReviews(3);
                if (recentReviews.Count == 0)
                {
                    flowRecentReviews.Controls.Add(new Label
                    {
                        Text = "Belum ada ulasan yang masuk.",
                        ForeColor = Color.Gray,
                        AutoSize = true
                    });
                }
                else
                {
                    foreach (var rev in recentReviews)
                    {
                        var pnlRev = new Panel
                        {
                            Width = flowRecentReviews.ClientSize.Width - 10,
                            AutoSize = true,
                            Margin = new Padding(0, 0, 0, 6)
                        };
                        var lblRevUser = new Label
                        {
                            Text = $"{rev.NamaUser}  {new string('⭐', rev.Rating)}  ·  {rev.NamaProduk}",
                            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                            Dock = DockStyle.Top,
                            AutoSize = true
                        };
                        var lblRevComment = new Label
                        {
                            Text = $"\"{rev.Komentar}\"",
                            Font = new Font("Segoe UI", 8f, FontStyle.Italic),
                            ForeColor = UIHelper.TeksSekunder,
                            Dock = DockStyle.Top,
                            AutoSize = true
                        };
                        pnlRev.Controls.Add(lblRevComment);
                        pnlRev.Controls.Add(lblRevUser);
                        flowRecentReviews.Controls.Add(pnlRev);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat dashboard: {ex.Message}", "Error Sistem");
            }
        }
    }
}
