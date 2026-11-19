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
    public partial class FormKatalog : BaseForm
    {
        private readonly ProdukService _produkService;
        private readonly CartService _cartService;
        private int? _selectedKategoriId = null;
        private List<Produk> _currentList = new();

        public FormKatalog()
        {
            InitializeComponent();
            _produkService = new ProdukService();
            _cartService = new CartService();

            cmbSort.SelectedIndex = 0;

            SetupSidebar();
            LoadKategoriButtons();
            RefreshCartCount();
            LoadProducts();

            txtSearch.TextChanged += (s, e) => LoadProducts();
            cmbSort.SelectedIndexChanged += (s, e) => ApplySortingAndRender();
            btnHeaderCart.Click += (s, e) => NavigateTo(this, new FormKeranjang());
            btnNavKeranjang.Click += (s, e) => NavigateTo(this, new FormKeranjang());
            btnNavRiwayat.Click += (s, e) => NavigateTo(this, new FormRiwayat());
            btnNavProfil.Click += (s, e) => NavigateTo(this, new FormProfil());
            btnKeluar.Click += (s, e) =>
            {
                if (Confirm("Apakah Anda yakin ingin keluar dari akun?", "Konfirmasi Keluar"))
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
                lblGreeting.Text = $"Halo, {user.Nama}! Temukan teh lokal pilihanmu · {DateTime.Now:dddd, d MMMM yyyy}";
            }
        }

        private void RefreshCartCount()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user != null)
            {
                int count = _cartService.GetItemCount(user.IdUser);
                btnHeaderCart.Text = $"🛒  Keranjang · {count} item";
                btnNavKeranjang.Text = $"🛒  Keranjang ({count})";
            }
        }

        private void LoadKategoriButtons()
        {
            pnlCategories.Controls.Clear();

            // Tombol "Semua"
            var btnAll = CreateCategoryButton("Semua", null);
            pnlCategories.Controls.Add(btnAll);

            try
            {
                var categories = _produkService.GetKategoriList();
                foreach (var kat in categories)
                {
                    var btn = CreateCategoryButton(kat.NamaKategori, kat.IdKategori);
                    pnlCategories.Controls.Add(btn);
                }
            }
            catch { /* fallback if database unavailable */ }
        }

        private Button CreateCategoryButton(string label, int? idKategori)
        {
            bool isSelected = _selectedKategoriId == idKategori;
            var btn = new Button
            {
                Text = label,
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
                _selectedKategoriId = idKategori;
                LoadKategoriButtons();
                LoadProducts();
            };
            return btn;
        }

        private void LoadProducts()
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                _currentList = _produkService.GetAllWithFilter(kw, _selectedKategoriId, true);
                ApplySortingAndRender();
            }
            catch (Exception ex)
            {
                flowProducts.Controls.Clear();
                var lblError = new Label
                {
                    Text = $"Gagal memuat produk: {ex.Message}\nPastikan PostgreSQL berjalan di localhost:5432.",
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10f)
                };
                flowProducts.Controls.Add(lblError);
            }
        }

        private void ApplySortingAndRender()
        {
            if (_currentList == null) return;

            var list = _currentList.ToList();
            switch (cmbSort.SelectedIndex)
            {
                case 0: // Rating tertinggi
                    list = list.OrderByDescending(p => p.RataRataRating).ThenByDescending(p => p.JumlahUlasan).ToList();
                    break;
                case 1: // Harga terendah
                    list = list.OrderBy(p => p.Harga).ToList();
                    break;
                case 2: // Harga tertinggi
                    list = list.OrderByDescending(p => p.Harga).ToList();
                    break;
                case 3: // Nama A-Z
                    list = list.OrderBy(p => p.Nama).ToList();
                    break;
            }

            flowProducts.Controls.Clear();

            if (list.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = "Produk tidak ditemukan untuk kata kunci atau kategori ini.",
                    ForeColor = UIHelper.TeksSekunder,
                    AutoSize = true,
                    Margin = new Padding(20),
                    Font = new Font("Segoe UI", 11f, FontStyle.Italic)
                };
                flowProducts.Controls.Add(lblEmpty);
                return;
            }

            foreach (var prod in list)
            {
                flowProducts.Controls.Add(CreateProductCard(prod));
            }
        }

        private Panel CreateProductCard(Produk p)
        {
            var card = new Panel
            {
                Size = new Size(212, 310),
                Margin = new Padding(0, 0, 16, 16),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            // Image/Illustration Box
            var pnlImg = new Panel
            {
                Dock = DockStyle.Top,
                Height = 115,
                BackColor = Color.FromArgb(238, 245, 238)
            };
            var lblLeaf = new Label
            {
                Text = "🍃",
                Font = new Font("Segoe UI", 32f),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlImg.Controls.Add(lblLeaf);
            pnlImg.Click += (s, e) => OpenDetail(p);
            lblLeaf.Click += (s, e) => OpenDetail(p);

            // Details Container
            var pnlBody = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 8, 10, 8)
            };

            var lblCatRegion = new Label
            {
                Text = $"{(string.IsNullOrEmpty(p.NamaKategori) ? "Teh" : p.NamaKategori)} · {p.AsalDaerah}",
                Font = new Font("Segoe UI", 8f),
                ForeColor = UIHelper.TeksSekunder,
                Dock = DockStyle.Top,
                Height = 16
            };

            var lblNama = new Label
            {
                Text = p.Nama,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = UIHelper.TeksUtama,
                Dock = DockStyle.Top,
                Height = 36
            };
            lblNama.Click += (s, e) => OpenDetail(p);

            var lblRating = new Label
            {
                Text = $"⭐ {p.RataRataRating:F1} ({p.JumlahUlasan} ulasan)",
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(160, 100, 20),
                Dock = DockStyle.Top,
                Height = 16
            };

            var pnlPriceStock = new Panel
            {
                Dock = DockStyle.Top,
                Height = 24
            };
            var lblPrice = new Label
            {
                Text = UIHelper.FormatRupiah(p.Harga),
                Font = new Font("Segoe UI", 10.5f, FontStyle.Bold),
                ForeColor = UIHelper.HijauUtama,
                Dock = DockStyle.Left,
                AutoSize = true
            };
            var lblStock = new Label
            {
                Text = p.Stok <= 5 ? $"Sisa {p.Stok}" : $"Stok {p.Stok}",
                Font = new Font("Segoe UI", 8f, p.Stok <= 5 ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = p.Stok <= 5 ? Color.FromArgb(190, 40, 40) : UIHelper.TeksSekunder,
                Dock = DockStyle.Right,
                AutoSize = true
            };
            pnlPriceStock.Controls.Add(lblStock);
            pnlPriceStock.Controls.Add(lblPrice);

            var btnAdd = new Button
            {
                Text = "+ Tambah ke Keranjang",
                Dock = DockStyle.Bottom,
                Height = 32,
                BackColor = Color.FromArgb(240, 246, 240),
                ForeColor = UIHelper.HijauUtama,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                UseVisualStyleBackColor = false
            };
            btnAdd.FlatAppearance.BorderColor = UIHelper.HijauUtama;
            btnAdd.Click += (s, e) =>
            {
                var user = SessionManager.Instance.CurrentUser;
                if (user == null)
                {
                    ShowError("Silakan login terlebih dahulu.", "Perlu Login");
                    return;
                }
                try
                {
                    _cartService.AddToCart(user.IdUser, p.IdProduk, 1);
                    RefreshCartCount();
                    ShowInfo($"'{p.Nama}' berhasil ditambahkan ke keranjang!", "Sukses");
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message, "Gagal Menambahkan");
                }
            };

            pnlBody.Controls.Add(btnAdd);
            pnlBody.Controls.Add(pnlPriceStock);
            pnlBody.Controls.Add(lblRating);
            pnlBody.Controls.Add(lblNama);
            pnlBody.Controls.Add(lblCatRegion);

            card.Controls.Add(pnlBody);
            card.Controls.Add(pnlImg);

            return card;
        }

        private void OpenDetail(Produk p)
        {
            var formDetail = new FormDetailProduk(p.IdProduk);
            formDetail.ShowDialog(this);
            RefreshCartCount();
        }
    }
}
