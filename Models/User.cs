using System;
using KalaRintikTea.Models.Enums;
using KalaRintikTea.Helpers;

namespace KalaRintikTea.Models
{
    public abstract class User
    {
        public int IdUser { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        private string _passwordHash = string.Empty;
        public string PasswordHash => _passwordHash;
        public string NoTelepon { get; set; } = string.Empty;
        public string Alamat { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        protected User() { }

        protected User(int idUser, string nama, string email, string passwordHash,
            string noTelepon, string alamat, DateTime createdAt)
        {
            IdUser = idUser;
            Nama = nama ?? string.Empty;
            Email = email ?? string.Empty;
            _passwordHash = passwordHash ?? string.Empty;
            NoTelepon = noTelepon ?? string.Empty;
            Alamat = alamat ?? string.Empty;
            CreatedAt = createdAt;
        }

        public abstract Role GetRole();

        public bool VerifyPassword(string plainPassword)
        {
            return PasswordHasher.Verify(plainPassword, _passwordHash);
        }

        public void SetPasswordHash(string hash)
        {
            _passwordHash = hash;
        }
    }
}
