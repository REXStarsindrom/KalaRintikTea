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
    public partial class FormUlasanAdmin : BaseForm
    {
        private readonly UlasanRepository _ulasanRepo;
        private List<Ulasan> _allReviews = new();

        public FormUlasanAdmin()
        {
            InitializeComponent();
            _ulasanRepo = new UlasanRepository();

            SetupSidebar();
            InitGrid();
            LoadReviews();

            txtSearch.TextChanged += (s, e) => FilterReviews();

            btnNavDashboard.Click += (s, e) => NavigateTo(this, new FormDashboardAdmin());
            btnNavDataBarang.Click += (s, e) => NavigateTo(this, new FormManajemenProduk());
            btnNavTransaksi.Click += (s, e) => NavigateTo(this, new FormTransaksiAdmin());
            btnNavPelanggan.Click += (s, e) => NavigateTo(this, new FormPelangganAdmin());
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
            dgvReviews.Columns.Clear();
            dgvReviews.Columns.Add("IdUlasan", "ID");
            dgvReviews.Columns["IdUlasan"].Width = 45;
            dgvReviews.Columns.Add("Tanggal", "Tanggal");
            dgvReviews.Columns.Add("Pelanggan", "Pelanggan");
            dgvReviews.Columns.Add("Produk", "Produk");
            dgvReviews.Columns.Add("Rating", "Rating");
            dgvReviews.Columns.Add("Komentar", "Komentar");

            dgvReviews.Columns["Tanggal"].FillWeight = 15;
            dgvReviews.Columns["Pelanggan"].FillWeight = 20;
            dgvReviews.Columns["Produk"].FillWeight = 25;
            dgvReviews.Columns["Rating"].FillWeight = 15;
            dgvReviews.Columns["Komentar"].FillWeight = 25;
        }

        private void LoadReviews()
        {
            try
            {
                _allReviews = _ulasanRepo.GetRecentReviews(50);
                FilterReviews();
            }
            catch (Exception ex)
            {
                ShowError($"Gagal memuat ulasan: {ex.Message}", "Error");
            }
        }

        private void FilterReviews()
        {
            dgvReviews.Rows.Clear();
            var filtered = _allReviews.AsEnumerable();

            string search = txtSearch.Text.Trim().ToLowerInvariant();
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(u =>
                    u.NamaUser.ToLowerInvariant().Contains(search) ||
                    u.NamaProduk.ToLowerInvariant().Contains(search) ||
                    u.Komentar.ToLowerInvariant().Contains(search));
            }

            var list = filtered.ToList();
            lblTotalCount.Text = $"Total: {list.Count} Ulasan";

            foreach (var u in list)
            {
                int rIdx = dgvReviews.Rows.Add(
                    u.IdUlasan,
                    u.Tanggal.ToString("dd MMM yyyy"),
                    u.NamaUser,
                    u.NamaProduk,
                    $"{new string('⭐', u.Rating)} ({u.Rating}/5)",
                    u.Komentar
                );

                var ratingCell = dgvReviews.Rows[rIdx].Cells["Rating"];
                ratingCell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                ratingCell.Style.ForeColor = Color.FromArgb(180, 110, 0);
            }
        }
    }
}
