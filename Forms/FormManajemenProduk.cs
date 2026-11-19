using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormManajemenProduk : BaseForm
    {
        private readonly ProdukService _produkService;
        private List<Produk> _allProducts = new();
        private List<Kategori> _kategoriList = new();
        private Produk? _selectedProduct = null;
        private bool _isCreateMode = false;

        public FormManajemenProduk()
        {
            InitializeComponent();
            _produkService = new ProdukService();

            SetupSidebar();
            InitGrid();
            LoadKategoriDropdowns();
            LoadProducts();

            txtSearch.TextChanged += (s, e) => FilterProducts();
            cmbFilterKategori.SelectedIndexChanged += (s, e) => FilterProducts();
            cmbFilterStatus.SelectedIndexChanged += (s, e) => FilterProducts();

            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            btnTambahBaru.Click += (s, e) => PrepareCreateNew();
            btnSimpan.Click += BtnSimpan_Click;
            btnToggleActive.Click += BtnToggleActive_Click;

            btnNavDashboard.Click += (s, e) => NavigateTo(this, new FormDashboardAdmin());
            btnNavTransaksi.Click += (s, e) => NavigateTo(this, new FormTransaksiAdmin());
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
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add("IdProduk", "ID");
            dgvProducts.Columns["IdProduk"].Width = 45;
            dgvProducts.Columns.Add("Produk", "Produk");
            dgvProducts.Columns.Add("Harga", "Harga");
            dgvProducts.Columns.Add("Stok", "Stok");
            dgvProducts.Columns.Add("Berat", "Berat");
            dgvProducts.Columns.Add("Rating", "Rating");
            dgvProducts.Columns.Add("Status", "Status");

            dgvProducts.Columns["Produk"].FillWeight = 35;
            dgvProducts.Columns["Harga"].FillWeight = 18;
            dgvProducts.Columns["Stok"].FillWeight = 12;
            dgvProducts.Columns["Berat"].FillWeight = 12;
            dgvProducts.Columns["Rating"].FillWeight = 11;
            dgvProducts.Columns["Status"].FillWeight = 12;
        }

        private void LoadKategoriDropdowns()
        {
            try
            {
                _kategoriList = _produkService.GetKategoriList();

                cmbFilterKategori.Items.Clear();
                cmbFilterKategori.Items.Add("Kategori: Semua");
                foreach (var k in _kategoriList)
                    cmbFilterKategori.Items.Add(k.NamaKategori);
                cmbFilterKategori.SelectedIndex = 0;

                cmbKategori.DataSource = new BindingSource(_kategoriList, null);
                cmbKategori.DisplayMember = "NamaKategori";
                cmbKategori.ValueMember = "IdKategori";
            }
            catch { }
            cmbFilterStatus.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            try
            {
                _allProducts = _produkService.GetAll();
                FilterProducts();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat produk: {ex.Message}", "Error");
            }
        }

        private void FilterProducts()
        {
            dgvProducts.Rows.Clear();
            var filtered = _allProducts.AsEnumerable();

            string search = txtSearch.Text.Trim().ToLowerInvariant();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(p =>
                    p.Nama.ToLowerInvariant().Contains(search) ||
                    p.Deskripsi.ToLowerInvariant().Contains(search) ||
                    p.AsalDaerah.ToLowerInvariant().Contains(search));
            }

            if (cmbFilterKategori.SelectedIndex > 0)
            {
                string katName = cmbFilterKategori.SelectedItem?.ToString() ?? "";
                filtered = filtered.Where(p => p.NamaKategori.Equals(katName, StringComparison.OrdinalIgnoreCase));
            }

            if (cmbFilterStatus.SelectedIndex == 1) // Aktif
                filtered = filtered.Where(p => p.IsActive);
            else if (cmbFilterStatus.SelectedIndex == 2) // Nonaktif
                filtered = filtered.Where(p => !p.IsActive);

            foreach (var p in filtered)
            {
                int rIdx = dgvProducts.Rows.Add(
                    p.IdProduk,
                    $"{p.Nama} ({p.NamaKategori})",
                    UIHelper.FormatRupiah(p.Harga),
                    p.Stok,
                    $"{p.BeratGram} g",
                    p.RataRataRating > 0 ? $"{p.RataRataRating:F1} ★" : "-",
                    p.IsActive ? "Aktif" : "Nonaktif"
                );

                var statusCell = dgvProducts.Rows[rIdx].Cells["Status"];
                statusCell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                statusCell.Style.ForeColor = p.IsActive ? UIHelper.HijauUtama : Color.FromArgb(190, 40, 40);

                var stokCell = dgvProducts.Rows[rIdx].Cells["Stok"];
                if (p.Stok <= 5)
                {
                    stokCell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                    stokCell.Style.ForeColor = Color.Red;
                }
            }

            if (dgvProducts.Rows.Count > 0)
            {
                dgvProducts.Rows[0].Selected = true;
            }
            else
            {
                PrepareCreateNew();
            }
        }

        private void DgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["IdProduk"].Value);
            _selectedProduct = _allProducts.FirstOrDefault(p => p.IdProduk == id);

            if (_selectedProduct != null)
            {
                _isCreateMode = false;
                lblEditorTitle.Text = $"Ubah Produk (ID {_selectedProduct.IdProduk})";
                txtNama.Text = _selectedProduct.Nama;
                txtDeskripsi.Text = _selectedProduct.Deskripsi;
                cmbKategori.SelectedValue = _selectedProduct.IdKategori;
                txtHarga.Text = _selectedProduct.Harga.ToString("0");
                txtStok.Text = _selectedProduct.Stok.ToString();
                txtBerat.Text = _selectedProduct.BeratGram.ToString();
                txtAsal.Text = _selectedProduct.AsalDaerah;
                txtPathGambar.Text = _selectedProduct.PathGambar;

                btnSimpan.Text = "Simpan Perubahan";
                btnToggleActive.Visible = true;
                btnToggleActive.Text = _selectedProduct.IsActive ? "Nonaktifkan" : "Aktifkan";
                btnToggleActive.BackColor = _selectedProduct.IsActive ? Color.FromArgb(254, 226, 226) : Color.FromArgb(220, 252, 231);
                btnToggleActive.ForeColor = _selectedProduct.IsActive ? Color.FromArgb(185, 28, 28) : Color.FromArgb(22, 101, 52);
            }
        }

        private void PrepareCreateNew()
        {
            _isCreateMode = true;
            _selectedProduct = null;
            lblEditorTitle.Text = "Tambah Produk Baru";
            txtNama.Text = "";
            txtDeskripsi.Text = "";
            if (cmbKategori.Items.Count > 0) cmbKategori.SelectedIndex = 0;
            txtHarga.Text = "50000";
            txtStok.Text = "20";
            txtBerat.Text = "100";
            txtAsal.Text = "Jember";
            txtPathGambar.Text = "img/teh.png";

            btnSimpan.Text = "Simpan Produk";
            btnToggleActive.Visible = false;
            txtNama.Focus();
        }

        private void BtnSimpan_Click(object? sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();
            string asal = txtAsal.Text.Trim();
            string pathGambar = txtPathGambar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama))
            {
                ShowError("Nama produk wajib diisi.", "Validasi");
                return;
            }

            if (!decimal.TryParse(txtHarga.Text.Trim(), out decimal harga) || harga <= 0)
            {
                ShowError("Harga harus berupa angka lebih dari 0.", "Validasi");
                return;
            }

            if (!int.TryParse(txtStok.Text.Trim(), out int stok) || stok < 0)
            {
                ShowError("Stok harus berupa angka non-negatif.", "Validasi");
                return;
            }

            if (!int.TryParse(txtBerat.Text.Trim(), out int berat) || berat <= 0)
            {
                berat = 100;
            }

            int idKategori = cmbKategori.SelectedValue is int idKat ? idKat : 1;

            try
            {
                if (_isCreateMode)
                {
                    var p = new Produk
                    {
                        IdKategori = idKategori,
                        Nama = nama,
                        Deskripsi = deskripsi,
                        Harga = harga,
                        BeratGram = berat,
                        AsalDaerah = asal,
                        PathGambar = pathGambar,
                        IsActive = true
                    };
                    p.SetStok(stok);

                    _produkService.AddProduk(p);
                    ShowInfo($"Produk '{nama}' berhasil ditambahkan!", "Sukses Tambah");
                }
                else if (_selectedProduct != null)
                {
                    _selectedProduct.Nama = nama;
                    _selectedProduct.Deskripsi = deskripsi;
                    _selectedProduct.IdKategori = idKategori;
                    _selectedProduct.Harga = harga;
                    _selectedProduct.SetStok(stok);
                    _selectedProduct.BeratGram = berat;
                    _selectedProduct.AsalDaerah = asal;
                    _selectedProduct.PathGambar = pathGambar;

                    _produkService.UpdateProduk(_selectedProduct);
                    ShowInfo($"Data produk '{nama}' berhasil diperbarui!", "Sukses Ubah");
                }

                LoadProducts();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal menyimpan produk: {ex.Message}", "Error");
            }
        }

        private void BtnToggleActive_Click(object? sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            bool targetActive = !_selectedProduct.IsActive;
            string actionText = targetActive ? "mengaktifkan kembali" : "menonaktifkan (soft delete)";

            if (Confirm($"Apakah Anda yakin ingin {actionText} produk '{_selectedProduct.Nama}'?", "Konfirmasi"))
            {
                try
                {
                    _produkService.SetActive(_selectedProduct.IdProduk, targetActive);
                    ShowInfo($"Produk berhasil di-{ (targetActive ? "aktifkan" : "nonaktifkan") }.", "Status Diperbarui");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    ShowError($"Gagal memperbarui status produk: {ex.Message}", "Error");
                }
            }
        }
    }
}
