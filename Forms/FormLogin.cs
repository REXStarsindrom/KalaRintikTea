using System;
using System.Windows.Forms;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormLogin : BaseForm
    {
        private readonly AuthService _authService;
        private bool _isPasswordShown = false;

        public FormLogin()
        {
            InitializeComponent();
            _authService = new AuthService();

            btnKembali.Click += (s, e) => NavigateTo(this, new FormLanding());
            btnTabDaftar.Click += (s, e) => NavigateTo(this, new FormRegister());
            lblBelumPunyaAkun.Click += (s, e) => NavigateTo(this, new FormRegister());
            btnShowPassword.Click += BtnShowPassword_Click;
            btnMasuk.Click += BtnMasuk_Click;
            txtPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnMasuk_Click(s, e); };
            lblLupaPassword.Click += (s, e) => ShowInfo("Silakan hubungi administrator toko untuk mereset kata sandi Anda di admin@kalarintik.id.", "Lupa Kata Sandi");
        }

        private void BtnShowPassword_Click(object? sender, EventArgs e)
        {
            _isPasswordShown = !_isPasswordShown;
            txtPassword.UseSystemPasswordChar = !_isPasswordShown;
            btnShowPassword.Text = _isPasswordShown ? "🙈" : "👁️";
        }

        private void BtnMasuk_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowError("Silakan masukkan email dan kata sandi Anda.", "Validasi Login");
                return;
            }

            try
            {
                var user = _authService.Login(email, password);
                if (user == null)
                {
                    ShowError("Email atau kata sandi yang Anda masukkan salah.", "Login Gagal");
                    return;
                }

                // Pengarahan Role sesuai Alur Flowchart
                if (user.GetRole() == Role.Admin)
                {
                    NavigateTo(this, new FormDashboardAdmin());
                }
                else
                {
                    NavigateTo(this, new FormKatalog());
                }
            }
            catch (Exception ex)
            {
                ShowError($"Terjadi kesalahan saat login: {ex.Message}", "Error Sistem");
            }
        }
    }
}
