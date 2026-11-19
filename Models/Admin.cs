using System;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Models
{
    public class Admin : User
    {
        public Admin() { }

        public Admin(int idUser, string nama, string email, string passwordHash,
            string noTelepon, string alamat, DateTime createdAt)
            : base(idUser, nama, email, passwordHash, noTelepon, alamat, createdAt)
        {
        }

        public override Role GetRole()
        {
            return Role.Admin;
        }
    }
}
