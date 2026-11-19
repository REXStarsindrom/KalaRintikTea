using System;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Services;

namespace KalaRintikTea.Forms
{
    public partial class FormProfil : BaseForm
    {
        private readonly AuthService _authService;

        public FormProfil()
        {
            InitializeComponent();
            _authService = new AuthService();

            SetupSidebar();
            LoadUserData();

            btnNavKatalog.Click += (s, e) => NavigateTo(this, new FormKatalog());
            btnNavKeranjang.Click += (s, e) => NavigateTo(this, new FormKeranjang());
            btnNavRiwayat.Click += (s, e) => NavigateTo(this, new FormRiwayat());
            btnKeluar.Click += (s, e) =>
            {
                if (Confirm("Apakah Anda yakin ingin keluar?", "Konfirmasi"))
                {
                    SessionManager.Instance.Logout();
                    NavigateTo(this, new FormLanding());
                }
            };

            btnSimpan.Click += BtnSimpan_Click;
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

        private void LoadUserData()
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user != null)
            {
                txtNama.Text = user.Nama;
                txtEmail.Text = user.Email;
                txtTelepon.Text = user.NoTelepon;
                txtAlamat.Text = user.Alamat;
                lblInfoJoined.Text = $"Bergabung sejak: {user.CreatedAt:dd MMMM yyyy}";
            }
        }

        private void BtnSimpan_Click(object? sender, EventArgs e)
        {
            var user = SessionManager.Instance.CurrentUser;
            if (user == null) return;

            string nama = txtNama.Text.Trim();
            string telepon = txtTelepon.Text.Trim();
            string alamat = txtAlamat.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama))
            {
                ShowError("Nama lengkap tidak boleh kosong.", "Validasi Profil");
                return;
            }

            try
            {
                _authService.UpdateProfile(user.IdUser, nama, telepon, alamat);
                SetupSidebar();
                ShowInfo("Perubahan profil Anda berhasil disimpan!", "Profil Diperbarui");
            }
            catch (Exception ex)
            {
                ShowError($"Gagal menyimpan profil: {ex.Message}", "Error");
            }
        }
    }
}
