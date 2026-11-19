using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormRiwayat : BaseForm
    {
        private readonly OrderService _orderService;
        private readonly ReviewService _reviewService;
        private List<Pesanan> _allOrders = new();
        private Pesanan? _selectedOrder;

        public FormRiwayat()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _reviewService = new ReviewService();

            cmbFilterStatus.SelectedIndex = 0;
            cmbRating.SelectedIndex = 0;

            SetupSidebar();
            InitGrid();
            LoadOrders();

            cmbFilterStatus.SelectedIndexChanged += (s, e) => FilterOrders();
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            btnKirimUlasan.Click += BtnKirimUlasan_Click;

            btnNavKatalog.Click += (s, e) => NavigateTo(this, new FormKatalog());
            btnNavKeranjang.Click += (s, e) => NavigateTo(this, new FormKeranjang());
            btnNavProfil.Click += (s, e) => NavigateTo(this, new FormProfil());
            btnKeluar.Click += (s, e) =>
            {
                if (Confirm("Apakah Anda yakin ingin keluar?", "Konfirmasi"))
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
                lblAvatar.Text = user.Nama.Length > 0 ? user.Nama.Substring(0, 1).ToUpper() : "U";
            }
        }

        private void InitGrid()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("IdPesanan", "ID");
            dgvOrders.Columns["IdPesanan"].Visible = false;
            dgvOrders.Columns.Add("KodePesanan", "Kode Pesanan");
            dgvOrders.Columns.Add("Tanggal", "Tanggal");
            dgvOrders.Columns.Add("Total", "Total");
            dgvOrders.Columns.Add("Pembayaran", "Pembayaran");
            dgvOrders.Columns.Add("Status", "Status");

            dgvOrders.Columns["KodePesanan"].FillWeight = 30;
            dgvOrders.Columns["Tanggal"].FillWeight = 20;
            dgvOrders.Columns["Total"].FillWeight = 20;
            dgvOrders.Columns["Pembayaran"].FillWeight = 15;
            dgvOrders.Columns["Status"].FillWeight = 15;
        }

        private void LoadOrders()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null) return;

            try
            {
                _allOrders = _orderService.GetOrdersByUser(user.IdUser);
                FilterOrders();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat pesanan: {ex.Message}", "Error");
            }
        }

        private void FilterOrders()
        {
            dgvOrders.Rows.Clear();
            var filtered = _allOrders.AsEnumerable();

            if (cmbFilterStatus.SelectedIndex > 0)
            {
                string statusText = cmbFilterStatus.SelectedItem?.ToString()?.Replace("Status: ", "") ?? "";
                if (Enum.TryParse<StatusPesanan>(statusText, out var st))
                {
                    filtered = filtered.Where(p => p.Status == st);
                }
            }

            foreach (var p in filtered)
            {
                int rowIndex = dgvOrders.Rows.Add(
                    p.IdPesanan,
                    p.KodePesanan,
                    p.TanggalPesanan.ToString("dd MMM yyyy, HH:mm"),
                    UIHelper.FormatRupiah(p.GrandTotal),
                    p.StatusPembayaran == StatusPembayaran.Lunas ? "Lunas" : "Belum Dibayar",
                    p.Status.ToString()
                );

                // Warna background baris berdasarkan status
                var cell = dgvOrders.Rows[rowIndex].Cells["Status"];
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

            if (dgvOrders.Rows.Count > 0)
            {
                dgvOrders.Rows[0].Selected = true;
            }
            else
            {
                ClearDetail();
            }
        }

        private void DgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0) return;

            int idPesanan = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["IdPesanan"].Value);
            _selectedOrder = _orderService.GetOrderById(idPesanan);

            if (_selectedOrder != null)
            {
                RenderOrderDetail(_selectedOrder);
            }
        }

        private void RenderOrderDetail(Pesanan p)
        {
            lblDetailKode.Text = $"{p.KodePesanan} · {p.TanggalPesanan:dd MMM yyyy}";
            lblDetailStatusBadge.Text = p.Status.ToString();
            lblDetailStatusBadge.BackColor = p.Status switch
            {
                StatusPesanan.Menunggu => UIHelper.KuningStatus,
                StatusPesanan.Diproses => UIHelper.BiruStatus,
                StatusPesanan.Dikirim => UIHelper.OranyeStatus,
                StatusPesanan.Selesai => UIHelper.HijauStatus,
                StatusPesanan.Dibatalkan => UIHelper.MerahStatus,
                _ => Color.LightGray
            };

            lblStepper.Text = p.Status switch
            {
                StatusPesanan.Menunggu => "🟡 [Menunggu] ➔ ⚪ Diproses ➔ ⚪ Dikirim ➔ ⚪ Selesai",
                StatusPesanan.Diproses => "🟢 Menunggu ➔ 🔵 [Diproses] ➔ ⚪ Dikirim ➔ ⚪ Selesai",
                StatusPesanan.Dikirim => "🟢 Menunggu ➔ 🟢 Diproses ➔ 🟠 [Dikirim] ➔ ⚪ Selesai",
                StatusPesanan.Selesai => "🟢 Menunggu ➔ 🟢 Diproses ➔ 🟢 Dikirim ➔ 🟢 [Selesai]",
                StatusPesanan.Dibatalkan => "🔴 Pesanan ini telah dibatalkan.",
                _ => ""
            };

            lblDetailAlamat.Text = $"Alamat Pengiriman:\n{p.AlamatPengiriman}";
            lblDetailPayment.Text = $"Metode: {p.MetodePembayaran}  ·  Status: {p.StatusPembayaran}";

            flowDetailItems.Controls.Clear();
            foreach (var d in p.Details)
            {
                var lblItem = new Label
                {
                    Text = $"🍃 {d.NamaProduk}\n   {d.Kuantitas}x @ {UIHelper.FormatRupiah(d.HargaSatuan)} = {UIHelper.FormatRupiah(d.Subtotal)}",
                    Font = new Font("Segoe UI", 8.5f),
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 6)
                };
                flowDetailItems.Controls.Add(lblItem);
            }

            lblDetailTotals.Text =
                $"Subtotal: {UIHelper.FormatRupiah(p.Subtotal)}\n" +
                $"Ongkir: {UIHelper.FormatRupiah(p.Ongkir)}\n" +
                $"Grand Total: {UIHelper.FormatRupiah(p.GrandTotal)}";

            // Tampilkan kotak ulasan HANYA jika status Selesai
            var user = SessionManager.Instance.CurrentUser;
            if (p.Status == StatusPesanan.Selesai && user != null && p.Details.Count > 0)
            {
                var firstProduct = p.Details[0];
                bool canReview = _reviewService.CanReview(user.IdUser, firstProduct.IdProduk, p.IdPesanan);
                pnlReviewBox.Visible = canReview;
                if (canReview)
                {
                    lblReviewPrompt.Text = $"Beri Ulasan untuk '{firstProduct.NamaProduk}':";
                }
            }
            else
            {
                pnlReviewBox.Visible = false;
            }
        }

        private void ClearDetail()
        {
            lblDetailKode.Text = "Belum ada pesanan yang dipilih";
            lblDetailStatusBadge.Text = "-";
            lblStepper.Text = "";
            lblDetailAlamat.Text = "Alamat Pengiriman:\n-";
            lblDetailPayment.Text = "";
            flowDetailItems.Controls.Clear();
            lblDetailTotals.Text = "";
            pnlReviewBox.Visible = false;
        }

        private void BtnKirimUlasan_Click(object? sender, EventArgs e)
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null || _selectedOrder == null || _selectedOrder.Details.Count == 0) return;

            int rating = 5 - cmbRating.SelectedIndex;
            string komentar = txtReviewComment.Text.Trim();

            if (string.IsNullOrWhiteSpace(komentar))
            {
                ShowError("Silakan tulis komentar ulasan Anda.", "Validasi");
                return;
            }

            try
            {
                var firstProduct = _selectedOrder.Details[0];
                var ulasan = new Ulasan
                {
                    IdUser = user.IdUser,
                    IdProduk = firstProduct.IdProduk,
                    IdPesanan = _selectedOrder.IdPesanan,
                    Rating = rating,
                    Komentar = komentar,
                    Tanggal = DateTime.Now
                };

                _reviewService.AddReview(ulasan);
                ShowInfo("Terima kasih! Ulasan dan rating Anda berhasil disimpan.", "Ulasan Terkirim");
                pnlReviewBox.Visible = false;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message, "Gagal Mengirim Ulasan");
            }
        }
    }
}
