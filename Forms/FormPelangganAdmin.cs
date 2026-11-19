using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Repositories;

namespace KalaRintikTea.Forms
{
    public partial class FormPelangganAdmin : BaseForm
    {
        private readonly UserRepository _userRepo;
        private List<User> _allCustomers = new();

        public FormPelangganAdmin()
        {
            InitializeComponent();
            _userRepo = new UserRepository();

            SetupSidebar();
            InitGrid();
            LoadCustomers();

            txtSearch.TextChanged += (s, e) => FilterCustomers();

            btnNavDashboard.Click += (s, e) => NavigateTo(this, new FormDashboardAdmin());
            btnNavDataBarang.Click += (s, e) => NavigateTo(this, new FormManajemenProduk());
            btnNavTransaksi.Click += (s, e) => NavigateTo(this, new FormTransaksiAdmin());
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
            dgvCustomers.Columns.Clear();
            dgvCustomers.Columns.Add("IdUser", "ID");
            dgvCustomers.Columns["IdUser"].Width = 50;
            dgvCustomers.Columns.Add("Nama", "Nama Pelanggan");
            dgvCustomers.Columns.Add("Email", "Email");
            dgvCustomers.Columns.Add("NoTelepon", "No. Telepon");
            dgvCustomers.Columns.Add("Alamat", "Alamat Pengiriman");
            dgvCustomers.Columns.Add("CreatedAt", "Terdaftar Sejak");

            dgvCustomers.Columns["Nama"].FillWeight = 22;
            dgvCustomers.Columns["Email"].FillWeight = 22;
            dgvCustomers.Columns["NoTelepon"].FillWeight = 16;
            dgvCustomers.Columns["Alamat"].FillWeight = 28;
            dgvCustomers.Columns["CreatedAt"].FillWeight = 12;
        }

        private void LoadCustomers()
        {
            try
            {
                _allCustomers = _userRepo.GetAllPelanggan();
                FilterCustomers();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat data pelanggan: {ex.Message}", "Error");
            }
        }

        private void FilterCustomers()
        {
            dgvCustomers.Rows.Clear();
            var filtered = _allCustomers.AsEnumerable();

            string search = txtSearch.Text.Trim().ToLowerInvariant();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(u =>
                    u.Nama.ToLowerInvariant().Contains(search) ||
                    u.Email.ToLowerInvariant().Contains(search) ||
                    u.NoTelepon.ToLowerInvariant().Contains(search) ||
                    u.Alamat.ToLowerInvariant().Contains(search));
            }

            var list = filtered.ToList();
            lblTotalCount.Text = $"Total: {list.Count} Pelanggan";

            foreach (var u in list)
            {
                dgvCustomers.Rows.Add(
                    u.IdUser,
                    u.Nama,
                    u.Email,
                    string.IsNullOrEmpty(u.NoTelepon) ? "-" : u.NoTelepon,
                    string.IsNullOrEmpty(u.Alamat) ? "-" : u.Alamat,
                    u.CreatedAt.ToString("dd MMM yyyy")
                );
            }
        }
    }
}
