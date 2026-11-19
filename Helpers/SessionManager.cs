// ============================================================
// FILE: Helpers/SessionManager.cs
// Kala Rintik Tea - Singleton Session Manager
// ============================================================
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Helpers
{
    public sealed class SessionManager
    {
        private static SessionManager? _instance;
        private static readonly object _lock = new();

        private SessionManager() { }

        /// <summary>Lazy-initialized singleton instance.</summary>
        public static SessionManager Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        _instance ??= new SessionManager();
                    }
                }
                return _instance;
            }
        }

        /// <summary>Pengguna yang sedang login.</summary>
        public User? CurrentUser { get; private set; }

        /// <summary>Apakah ada pengguna yang sedang login.</summary>
        public bool IsLoggedIn => CurrentUser is not null;

        /// <summary>Set pengguna aktif.</summary>
        public void Login(User user)
        {
            CurrentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        /// <summary>Hapus sesi pengguna.</summary>
        public void Logout()
        {
            CurrentUser = null;
        }

        /// <summary>
        /// Memastikan pengguna aktif memiliki role yang sesuai.
        /// Melempar UnauthorizedAccessException jika tidak.
        /// </summary>
        public void RequireRole(Role role)
        {
            if (!IsLoggedIn)
                throw new UnauthorizedAccessException("Belum login.");

            if (CurrentUser!.GetRole() != role)
                throw new UnauthorizedAccessException(
                    $"Akses ditolak. Diperlukan role {role}, tetapi Anda adalah {CurrentUser.GetRole()}.");
        }
    }
}
