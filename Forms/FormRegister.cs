using System;
using System.Windows.Forms;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormRegister : BaseForm
    {
        private readonly AuthService _authService;

        public FormRegister()
        {
            InitializeComponent();
            _authService = new AuthService();

            btnKembali.Click += (s, e) => NavigateTo(this, new FormLanding());
            btnTabLogin.Click += (s, e) => NavigateTo(this, new FormLogin());
            lblSudahPunyaAkun.Click += (s, e) => NavigateTo(this, new FormLogin());
            btnDaftar.Click += BtnDaftar_Click;
        }

        private void BtnDaftar_Click(object? sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telepon = txtTelepon.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // Validasi Sesuai Flowchart Registrasi Pelanggan
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowError("Mohon lengkapi nama, email, dan kata sandi Anda.", "Validasi Registrasi");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                ShowError("Format email tidak valid. Pastikan menyertakan '@' dan domain.", "Format Email Salah");
                return;
            }

            if (password.Length < 6)
            {
                ShowError("Kata sandi minimal harus 6 karakter.", "Kata Sandi Kurang Panjang");
                return;
            }

            if (password != confirm)
            {
                ShowError("Konfirmasi kata sandi tidak cocok. Silakan periksa kembali.", "Kata Sandi Berbeda");
                return;
            }

            try
            {
                var newUser = _authService.Register(nama, email, password, telepon, alamat);
                ShowInfo($"Akun atas nama '{newUser.Nama}' berhasil didaftarkan!\nSilakan login untuk mulai berbelanja.", "Registrasi Berhasil");
                NavigateTo(this, new FormLogin());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message, "Registrasi Gagal");
            }
        }
    }
}
