using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Repositories;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormTransaksiAdmin : BaseForm
    {
        private readonly OrderService _orderService;
        private readonly UserRepository _userRepo;
        private List<Pesanan> _allOrders = new();
        private Pesanan? _selectedOrder;
        private StatusPesanan? _filterStatus = null;

        public FormTransaksiAdmin()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _userRepo = new UserRepository();

            cmbFilterMetode.SelectedIndex = 0;

            SetupSidebar();
            InitGrid();
            LoadStatusTabs();
            LoadOrders();

            txtSearch.TextChanged += (s, e) => FilterOrders();
            cmbFilterMetode.SelectedIndexChanged += (s, e) => FilterOrders();
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;

            btnAdvanceStatus.Click += BtnAdvanceStatus_Click;
            btnCancelOrder.Click += BtnCancelOrder_Click;

            btnNavDashboard.Click += (s, e) => NavigateTo(this, new FormDashboardAdmin());
            btnNavDataBarang.Click += (s, e) => NavigateTo(this, new FormManajemenProduk());
            btnNavPelanggan.Click += (s, e) => NavigateTo(this, new FormPelangganAdmin());
            btnNavUlasan.Click += (s, e) => NavigateTo(this, new FormUlasanAdmin());
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
                lblAvatar.Text = user.Nama.Length > 0 ? user.Nama.Substring(0, 1).ToUpper() : "A";
            }
        }

        private void InitGrid()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("IdPesanan", "ID");
            dgvOrders.Columns["IdPesanan"].Visible = false;
            dgvOrders.Columns.Add("KodePesanan", "Kode Pesanan");
            dgvOrders.Columns.Add("Tanggal", "Tanggal");
            dgvOrders.Columns.Add("Metode", "Metode");
            dgvOrders.Columns.Add("Total", "Total");
            dgvOrders.Columns.Add("Status", "Status");

            dgvOrders.Columns["KodePesanan"].FillWeight = 30;
            dgvOrders.Columns["Tanggal"].FillWeight = 22;
            dgvOrders.Columns["Metode"].FillWeight = 18;
            dgvOrders.Columns["Total"].FillWeight = 18;
            dgvOrders.Columns["Status"].FillWeight = 15;
        }

        private void LoadStatusTabs()
        {
            flowStatusTabs.Controls.Clear();
            var tabs = new (string label, StatusPesanan? st)[]
            {
                ("Semua", null),
                ("Menunggu", StatusPesanan.Menunggu),
                ("Diproses", StatusPesanan.Diproses),
                ("Dikirim", StatusPesanan.Dikirim),
                ("Selesai", StatusPesanan.Selesai),
                ("Dibatalkan", StatusPesanan.Dibatalkan)
            };

            foreach (var tab in tabs)
            {
                bool isSelected = _filterStatus == tab.st;
                var btn = new Button
                {
                    Text = tab.label,
                    AutoSize = true,
                    Height = 32,
                    Margin = new Padding(0, 0, 8, 0),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    Font = new Font("Segoe UI", 9.5f, isSelected ? FontStyle.Bold : FontStyle.Regular),
                    BackColor = isSelected ? UIHelper.HijauUtama : Color.White,
                    ForeColor = isSelected ? Color.White : UIHelper.TeksUtama,
                    UseVisualStyleBackColor = false
                };
                btn.FlatAppearance.BorderColor = isSelected ? UIHelper.HijauUtama : UIHelper.BorderHalus;
                btn.Click += (s, e) =>
                {
                    _filterStatus = tab.st;
                    LoadStatusTabs();
                    FilterOrders();
                };
                flowStatusTabs.Controls.Add(btn);
            }
        }

        private void LoadOrders()
        {
            try
            {
                _allOrders = _orderService.GetAllOrders();
                FilterOrders();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat daftar pesanan: {ex.Message}", "Error");
            }
        }

        private void FilterOrders()
        {
            dgvOrders.Rows.Clear();
            var filtered = _allOrders.AsEnumerable();

            if (_filterStatus.HasValue)
            {
                filtered = filtered.Where(p => p.Status == _filterStatus.Value);
            }

            string search = txtSearch.Text.Trim().ToLowerInvariant();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(p =>
                    p.KodePesanan.ToLowerInvariant().Contains(search) ||
                    p.AlamatPengiriman.ToLowerInvariant().Contains(search));
            }

            if (cmbFilterMetode.SelectedIndex > 0)
            {
                string met = cmbFilterMetode.SelectedItem?.ToString() ?? "";
                filtered = filtered.Where(p => p.MetodePembayaran.ToString().Equals(met, StringComparison.OrdinalIgnoreCase) ||
                                               (met == "Dompet Digital" && p.MetodePembayaran == MetodePembayaran.DompetDigital));
            }

            foreach (var p in filtered)
            {
                int rIdx = dgvOrders.Rows.Add(
                    p.IdPesanan,
                    p.KodePesanan,
                    p.TanggalPesanan.ToString("dd MMM, HH:mm"),
                    p.MetodePembayaran.ToString(),
                    UIHelper.FormatRupiah(p.GrandTotal),
                    p.Status.ToString()
                );

                var cell = dgvOrders.Rows[rIdx].Cells["Status"];
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

            int id = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["IdPesanan"].Value);
            _selectedOrder = _orderService.GetOrderById(id);

            if (_selectedOrder != null)
            {
                RenderDetail(_selectedOrder);
            }
        }

        private void RenderDetail(Pesanan p)
        {
            lblDetailKode.Text = $"{p.KodePesanan} · {p.TanggalPesanan:dd MMM yyyy, HH:mm}";
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
                StatusPesanan.Dibatalkan => "🔴 Pesanan Dibatalkan",
                _ => ""
            };

            var user = _userRepo.GetById(p.IdUser);
            lblCustomerInfo.Text = $"Pelanggan: {user?.Nama ?? "User #" + p.IdUser} (Telp: {user?.NoTelepon ?? "-"})\nAlamat (Snapshot): {p.AlamatPengiriman}";

            flowDetailItems.Controls.Clear();
            foreach (var d in p.Details)
            {
                var lblItem = new Label
                {
                    Text = $"🍃 {d.NamaProduk}\n   {d.Kuantitas}x @ {UIHelper.FormatRupiah(d.HargaSatuan)} = {UIHelper.FormatRupiah(d.Subtotal)}",
                    Font = new Font("Segoe UI", 8.5f),
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 4)
                };
                flowDetailItems.Controls.Add(lblItem);
            }

            lblSummary.Text =
                $"Subtotal: {UIHelper.FormatRupiah(p.Subtotal)}\n" +
                $"Ongkir: {UIHelper.FormatRupiah(p.Ongkir)}\n" +
                $"Grand Total: {UIHelper.FormatRupiah(p.GrandTotal)}";

            lblPaymentInfo.Text = $"{p.MetodePembayaran} · Status: {p.StatusPembayaran}";

            // Konfigurasi Tombol Alur Transaksi
            switch (p.Status)
            {
                case StatusPesanan.Menunggu:
                    btnAdvanceStatus.Visible = true;
                    btnAdvanceStatus.Text = "✓  Ubah status ➔ Diproses";
                    btnCancelOrder.Visible = true;
                    break;
                case StatusPesanan.Diproses:
                    btnAdvanceStatus.Visible = true;
                    btnAdvanceStatus.Text = "✓  Ubah status ➔ Dikirim";
                    btnCancelOrder.Visible = true;
                    break;
                case StatusPesanan.Dikirim:
                    btnAdvanceStatus.Visible = true;
                    btnAdvanceStatus.Text = "✓  Ubah status ➔ Selesai";
                    btnCancelOrder.Visible = false;
                    break;
                default: // Selesai atau Dibatalkan
                    btnAdvanceStatus.Visible = false;
                    btnCancelOrder.Visible = false;
                    break;
            }
        }

        private void ClearDetail()
        {
            lblDetailKode.Text = "Belum ada pesanan yang dipilih";
            lblDetailStatusBadge.Text = "-";
            lblStepper.Text = "";
            lblCustomerInfo.Text = "Pelanggan:\nAlamat:";
            flowDetailItems.Controls.Clear();
            lblSummary.Text = "Subtotal: Rp 0\nOngkir: Rp 0\nGrand Total: Rp 0";
            lblPaymentInfo.Text = "";
            btnAdvanceStatus.Visible = false;
            btnCancelOrder.Visible = false;
        }

        private void BtnAdvanceStatus_Click(object? sender, EventArgs e)
        {
            if (_selectedOrder == null) return;

            StatusPesanan targetStatus = _selectedOrder.Status switch
            {
                StatusPesanan.Menunggu => StatusPesanan.Diproses,
                StatusPesanan.Diproses => StatusPesanan.Dikirim,
                StatusPesanan.Dikirim => StatusPesanan.Selesai,
                _ => _selectedOrder.Status
            };

            if (Confirm($"Ubah status pesanan '{_selectedOrder.KodePesanan}' menjadi '{targetStatus}'?", "Konfirmasi Alur Status"))
            {
                try
                {
                    _orderService.UpdateStatus(_selectedOrder.IdPesanan, targetStatus);
                    ShowInfo($"Status pesanan berhasil diubah menjadi '{targetStatus}'!", "Sukses");
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message, "Gagal Mengubah Status");
                }
            }
        }

        private void BtnCancelOrder_Click(object? sender, EventArgs e)
        {
            if (_selectedOrder == null) return;

            if (Confirm($"Apakah Anda yakin ingin membatalkan pesanan '{_selectedOrder.KodePesanan}'?\nStok produk akan otomatis dikembalikan ke gudang.", "Konfirmasi Pembatalan"))
            {
                try
                {
                    _orderService.UpdateStatus(_selectedOrder.IdPesanan, StatusPesanan.Dibatalkan);
                    ShowInfo($"Pesanan '{_selectedOrder.KodePesanan}' berhasil dibatalkan dan stok produk telah dikembalikan.", "Pesanan Dibatalkan");
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message, "Gagal Membatalkan Pesanan");
                }
            }
        }
    }
}
