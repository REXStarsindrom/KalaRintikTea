using System;
using KalaRintikTea.Helpers;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Repositories;

namespace KalaRintikTea.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;
        private readonly KeranjangRepository _keranjangRepo;

        public AuthService(UserRepository? userRepo = null, KeranjangRepository? keranjangRepo = null)
        {
            _userRepo = userRepo ?? new UserRepository();
            _keranjangRepo = keranjangRepo ?? new KeranjangRepository();
        }

        public User? Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Email dan password harus diisi.");

            var user = _userRepo.GetByEmail(email.Trim());
            if (user == null)
                return null;

            if (!user.VerifyPassword(password))
                return null;

            SessionManager.Instance.Login(user);
            return user;
        }

        public User Register(string nama, string email, string password, string noTelepon, string alamat)
        {
            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama lengkap wajib diisi.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email wajib diisi.");
            if (!email.Contains("@") || !email.Contains("."))
                throw new ArgumentException("Format email tidak valid.");
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ArgumentException("Kata sandi minimal 6 karakter.");

            email = email.Trim().ToLowerInvariant();

            if (_userRepo.EmailExists(email))
                throw new InvalidOperationException("Email sudah terdaftar. Silakan gunakan email lain.");

            string hash = PasswordHasher.Hash(password);

            var pelanggan = new Pelanggan(
                0,
                nama.Trim(),
                email,
                hash,
                noTelepon?.Trim() ?? string.Empty,
                alamat?.Trim() ?? string.Empty,
                DateTime.Now
            );

            int id = _userRepo.Add(pelanggan);
            pelanggan.IdUser = id;

            // Inisialisasi keranjang belanja untuk pelanggan baru
            _keranjangRepo.CreateForUser(id);

            return pelanggan;
        }

        public void Logout()
        {
            SessionManager.Instance.Logout();
        }

        public bool UpdateProfile(int userId, string nama, string noTelepon, string alamat)
        {
            var user = _userRepo.GetById(userId);
            if (user == null)
                throw new KeyNotFoundException("User tidak ditemukan.");

            user.Nama = nama.Trim();
            user.NoTelepon = noTelepon?.Trim() ?? string.Empty;
            user.Alamat = alamat?.Trim() ?? string.Empty;

            bool updated = _userRepo.Update(user);
            if (updated && SessionManager.Instance.CurrentUser?.IdUser == userId)
            {
                SessionManager.Instance.CurrentUser.Nama = user.Nama;
                SessionManager.Instance.CurrentUser.NoTelepon = user.NoTelepon;
                SessionManager.Instance.CurrentUser.Alamat = user.Alamat;
            }

            return updated;
        }
    }
}
