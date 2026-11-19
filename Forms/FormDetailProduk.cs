using System;
using System.Drawing;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormDetailProduk : Form
    {
        private readonly int _idProduk;
        private readonly ProdukService _produkService;
        private readonly CartService _cartService;
        private readonly ReviewService _reviewService;
        private Produk? _produk;
        private int _qty = 1;

        public FormDetailProduk(int idProduk)
        {
            InitializeComponent();
            _idProduk = idProduk;
            _produkService = new ProdukService();
            _cartService = new CartService();
            _reviewService = new ReviewService();

            btnMinus.Click += (s, e) => { if (_qty > 1) { _qty--; txtQty.Text = _qty.ToString(); } };
            btnPlus.Click += (s, e) =>
            {
                if (_produk != null && _qty < _produk.Stok)
                {
                    _qty++;
                    txtQty.Text = _qty.ToString();
                }
                else
                {
                    MessageBox.Show(this, "Jumlah melebihi stok yang tersedia.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            btnAddToCart.Click += BtnAddToCart_Click;
            btnClose.Click += (s, e) => this.Close();

            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                _produk = _produkService.GetById(_idProduk);
                if (_produk == null)
                {
                    MessageBox.Show(this, "Produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblCatOrigin.Text = $"{_produk.NamaKategori} · Asal {_produk.AsalDaerah}";
                lblNama.Text = _produk.Nama;
                lblRating.Text = $"⭐ {_produk.RataRataRating:F1} ({_produk.JumlahUlasan} ulasan)";
                lblHarga.Text = UIHelper.FormatRupiah(_produk.Harga);
                lblStokBerat.Text = $"Stok: {_produk.Stok} unit  ·  Berat: {_produk.BeratGram} gram";
                lblDesc.Text = string.IsNullOrEmpty(_produk.Deskripsi) ? "Belum ada deskripsi." : _produk.Deskripsi;

                if (_produk.Stok <= 0)
                {
                    btnAddToCart.Enabled = false;
                    btnAddToCart.Text = "Stok Habis";
                    btnAddToCart.BackColor = Color.Gray;
                }

                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Gagal memuat detail produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReviews()
        {
            flowReviews.Controls.Clear();
            var reviews = _reviewService.GetByProduk(_idProduk);

            if (reviews.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = "Belum ada ulasan untuk produk ini.",
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                flowReviews.Controls.Add(lblEmpty);
                return;
            }

            foreach (var rev in reviews)
            {
                var pnl = new Panel
                {
                    Width = 500,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 8),
                    BackColor = Color.White,
                    Padding = new Padding(8)
                };

                var lblRevUser = new Label
                {
                    Text = $"{rev.NamaUser} — {new string('⭐', rev.Rating)}",
                    Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                    ForeColor = UIHelper.TeksUtama,
                    Dock = DockStyle.Top,
                    AutoSize = true
                };

                var lblRevComment = new Label
                {
                    Text = rev.Komentar,
                    Font = new Font("Segoe UI", 8.5f),
                    ForeColor = UIHelper.TeksSekunder,
                    Dock = DockStyle.Top,
                    AutoSize = true
                };

                var lblRevDate = new Label
                {
                    Text = rev.Tanggal.ToString("d MMMM yyyy"),
                    Font = new Font("Segoe UI", 7.5f),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top,
                    AutoSize = true
                };

                pnl.Controls.Add(lblRevDate);
                pnl.Controls.Add(lblRevComment);
                pnl.Controls.Add(lblRevUser);

                flowReviews.Controls.Add(pnl);
            }
        }

        private void BtnAddToCart_Click(object? sender, EventArgs e)
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null)
            {
                MessageBox.Show(this, "Silakan login terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _cartService.AddToCart(user.IdUser, _idProduk, _qty);
                MessageBox.Show(this, $"{_qty} item '{_produk?.Nama}' berhasil dimasukkan ke keranjang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Gagal Menambahkan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
