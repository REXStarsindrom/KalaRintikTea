using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Payment;
using KalaRintikTea.Services;
using KalaRintikTea.Shipping;

namespace KalaRintikTea.Forms
{
    public partial class FormKeranjang : BaseForm
    {
        private readonly CartService _cartService;
        private readonly OrderService _orderService;
        private Keranjang? _cart;

        public FormKeranjang()
        {
            InitializeComponent();
            _cartService = new CartService();
            _orderService = new OrderService();

            SetupSidebar();
            LoadCart();

            btnLanjutBelanja.Click += (s, e) => NavigateTo(this, new FormKatalog());
            btnNavKatalog.Click += (s, e) => NavigateTo(this, new FormKatalog());
            btnNavRiwayat.Click += (s, e) => NavigateTo(this, new FormRiwayat());
            btnNavProfil.Click += (s, e) => NavigateTo(this, new FormProfil());
            btnKeluar.Click += (s, e) =>
            {
                if (Confirm("Apakah Anda yakin ingin keluar?", "Konfirmasi"))
                {
                    SessionManager.Instance.Logout();
                    NavigateTo(this, new FormLanding());
                }
            };

            btnBuatPesanan.Click += BtnBuatPesanan_Click;
        }

        private void SetupSidebar()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user != null)
            {
                lblUserName.Text = user.Nama;
                lblAvatar.Text = user.Nama.Length > 0 ? user.Nama.Substring(0, 1).ToUpper() : "U";
                txtAlamat.Text = string.IsNullOrEmpty(user.Alamat) ? "Jl. Kalimantan No. 37, Sumbersari, Jember" : user.Alamat;
            }
        }

        private void LoadCart()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null) return;

            flowCartItems.Controls.Clear();

            try
            {
                _cart = _cartService.GetCart(user.IdUser);

                if (_cart == null || _cart.Items.Count == 0)
                {
                    var lblEmpty = new Label
                    {
                        Text = "Keranjang belanjamu masih kosong.\nYuk pilih teh lokal favoritmu!",
                        ForeColor = UIHelper.TeksSekunder,
                        Font = new Font("Segoe UI", 11f, FontStyle.Italic),
                        AutoSize = true,
                        Margin = new Padding(20)
                    };
                    flowCartItems.Controls.Add(lblEmpty);
                    btnBuatPesanan.Enabled = false;
                    UpdateSummary(0, 0);
                    return;
                }

                btnBuatPesanan.Enabled = true;

                foreach (var item in _cart.Items)
                {
                    flowCartItems.Controls.Add(CreateCartItemRow(item));
                }

                decimal subtotal = _cartService.GetSubtotal(_cart);
                int totalBerat = _cartService.GetTotalBerat(_cart);
                UpdateSummary(subtotal, totalBerat);
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat keranjang: {ex.Message}", "Error");
            }
        }

        private Panel CreateCartItemRow(ItemKeranjang item)
        {
            var row = new Panel
            {
                Width = flowCartItems.ClientSize.Width - 30,
                Height = 75,
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Leaf Icon
            var lblIcon = new Label
            {
                Text = "🍃",
                Font = new Font("Segoe UI", 20f),
                Location = new Point(10, 15),
                Size = new Size(40, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Name & Info
            var lblName = new Label
            {
                Text = item.Produk.Nama,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Location = new Point(55, 12),
                Size = new Size(200, 20),
                AutoEllipsis = true
            };

            var lblDetails = new Label
            {
                Text = $"{item.Produk.BeratGram}g · Stok {item.Produk.Stok}",
                Font = new Font("Segoe UI", 8f),
                ForeColor = UIHelper.TeksSekunder,
                Location = new Point(55, 34),
                Size = new Size(200, 18)
            };

            var lblUnitPrice = new Label
            {
                Text = UIHelper.FormatRupiah(item.Produk.Harga),
                Font = new Font("Segoe UI", 9f),
                ForeColor = UIHelper.TeksSekunder,
                Location = new Point(55, 52),
                Size = new Size(120, 18)
            };

            // Minus Qty Button
            var btnMin = new Button
            {
                Text = "-",
                Location = new Point(270, 22),
                Size = new Size(28, 28),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnMin.Click += (s, e) =>
            {
                if (item.Kuantitas > 1)
                {
                    _cartService.UpdateQty(item.IdItem, item.Kuantitas - 1);
                    LoadCart();
                }
                else
                {
                    if (Confirm($"Hapus '{item.Produk.Nama}' dari keranjang?", "Konfirmasi Hapus"))
                    {
                        _cartService.RemoveItem(item.IdItem);
                        LoadCart();
                    }
                }
            };

            // Qty Display
            var lblQty = new Label
            {
                Text = item.Kuantitas.ToString(),
                Location = new Point(300, 24),
                Size = new Size(30, 24),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold)
            };

            // Plus Qty Button
            var btnPlu = new Button
            {
                Text = "+",
                Location = new Point(332, 22),
                Size = new Size(28, 28),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnPlu.Click += (s, e) =>
            {
                if (item.Kuantitas < item.Produk.Stok)
                {
                    _cartService.UpdateQty(item.IdItem, item.Kuantitas + 1);
                    LoadCart();
                }
                else
                {
                    ShowError("Jumlah melebihi stok yang tersedia.", "Batas Stok");
                }
            };

            // Subtotal
            var subtotal = item.Produk.Harga * item.Kuantitas;
            var lblSub = new Label
            {
                Text = UIHelper.FormatRupiah(subtotal),
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = UIHelper.HijauUtama,
                Location = new Point(370, 25),
                Size = new Size(95, 24),
                TextAlign = ContentAlignment.MiddleRight
            };

            // Delete Button
            var btnDel = new Button
            {
                Text = "🗑️",
                Location = new Point(475, 22),
                Size = new Size(28, 28),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                ForeColor = Color.Red
            };
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.Click += (s, e) =>
            {
                if (Confirm($"Hapus '{item.Produk.Nama}' dari keranjang?", "Konfirmasi Hapus"))
                {
                    _cartService.RemoveItem(item.IdItem);
                    LoadCart();
                }
            };

            row.Controls.Add(btnDel);
            row.Controls.Add(lblSub);
            row.Controls.Add(btnPlu);
            row.Controls.Add(lblQty);
            row.Controls.Add(btnMin);
            row.Controls.Add(lblUnitPrice);
            row.Controls.Add(lblDetails);
            row.Controls.Add(lblName);
            row.Controls.Add(lblIcon);

            return row;
        }

        private void UpdateSummary(decimal subtotal, int totalBerat)
        {
            var calc = new FlatRateShippingCalculator();
            decimal ongkir = subtotal > 0 ? calc.Hitung(totalBerat) : 0m;
            decimal grandTotal = subtotal + ongkir;

            lblSummarySubtotal.Text = $"Subtotal: {UIHelper.FormatRupiah(subtotal)}";
            lblSummaryBerat.Text = $"Total berat: {totalBerat:N0} g";
            lblSummaryOngkir.Text = $"Ongkir (Flat): {UIHelper.FormatRupiah(ongkir)}";
            lblSummaryGrandTotal.Text = $"Grand Total: {UIHelper.FormatRupiah(grandTotal)}";
        }

        private void BtnBuatPesanan_Click(object? sender, EventArgs e)
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null)
            {
                ShowError("Silakan login kembali.", "Perlu Login");
                return;
            }

            string alamat = txtAlamat.Text.Trim();
            if (string.IsNullOrWhiteSpace(alamat))
            {
                ShowError("Mohon lengkapi alamat pengiriman.", "Validasi Checkout");
                return;
            }

            MetodePembayaran metode = rbTransfer.Checked ? MetodePembayaran.Transfer :
                                      rbCod.Checked ? MetodePembayaran.COD :
                                      MetodePembayaran.DompetDigital;

            string catatan = txtCatatan.Text.Trim();
            var calc = new FlatRateShippingCalculator();

            try
            {
                // Checkout transaksi ACID
                var pesanan = _orderService.Checkout(user.IdUser, alamat, metode, catatan, calc);

                // Polimorfisme: Pembayaran melalui Factory
                var paymentMethod = PaymentMethodFactory.Create(metode);
                string instruksi = paymentMethod.BuatInstruksi(pesanan);

                // Tampilkan dialog instruksi pembayaran
                MessageBox.Show(this,
                    $"Pesanan berhasil dibuat!\n\n" +
                    $"Kode Pesanan: {pesanan.KodePesanan}\n" +
                    $"Total Pembayaran: {UIHelper.FormatRupiah(pesanan.GrandTotal)}\n\n" +
                    $"---------------------------------------------\n" +
                    $"{instruksi}\n" +
                    $"---------------------------------------------\n\n" +
                    $"Status pesanan dapat Anda pantau di menu 'Riwayat Pesanan'.",
                    "Pesanan Berhasil Dibuat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                NavigateTo(this, new FormRiwayat());
            }
            catch (Exception ex)
            {
                ShowError($"Checkout gagal: {ex.Message}", "Transaksi Dibatalkan");
            }
        }
    }
}
