using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;
using KalaRintikTea.Models.Enums;

namespace KalaRintikTea.Repositories
{
    public class UserRepository : BaseRepository
    {
        private User MapUser(NpgsqlDataReader reader)
        {
            var roleStr = reader.GetString(reader.GetOrdinal("role"));
            var role = Enum.Parse<Role>(roleStr, true);

            int idUser = reader.GetInt32(reader.GetOrdinal("id_user"));
            string nama = reader.GetString(reader.GetOrdinal("nama"));
            string email = reader.GetString(reader.GetOrdinal("email"));
            string passwordHash = reader.GetString(reader.GetOrdinal("password_hash"));
            string? noTelepon = reader.IsDBNull(reader.GetOrdinal("no_telepon"))
                ? string.Empty : reader.GetString(reader.GetOrdinal("no_telepon"));
            string? alamat = reader.IsDBNull(reader.GetOrdinal("alamat"))
                ? string.Empty : reader.GetString(reader.GetOrdinal("alamat"));
            DateTime createdAt = reader.GetDateTime(reader.GetOrdinal("created_at"));

            if (role == Role.Admin)
                return new Admin(idUser, nama, email, passwordHash, noTelepon!, alamat!, createdAt);
            else
                return new Pelanggan(idUser, nama, email, passwordHash, noTelepon!, alamat!, createdAt);
        }

        public User? GetByEmail(string email)
        {
            const string sql = "SELECT * FROM users WHERE LOWER(email) = LOWER(@email)";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapUser(reader);
            return null;
        }

        public User? GetById(int id)
        {
            const string sql = "SELECT * FROM users WHERE id_user = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapUser(reader);
            return null;
        }

        public int Add(User user)
        {
            const string sql = @"
                INSERT INTO users (nama, email, password_hash, role, no_telepon, alamat)
                VALUES (@nama, @email, @password_hash, @role, @no_telepon, @alamat)
                RETURNING id_user";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", user.Nama);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password_hash", user.PasswordHash);
            cmd.Parameters.AddWithValue("@role", user.GetRole().ToString());
            cmd.Parameters.AddWithValue("@no_telepon", (object?)user.NoTelepon ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@alamat", (object?)user.Alamat ?? DBNull.Value);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Update(User user)
        {
            const string sql = @"
                UPDATE users 
                SET nama = @nama, no_telepon = @no_telepon, alamat = @alamat
                WHERE id_user = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", user.Nama);
            cmd.Parameters.AddWithValue("@no_telepon", (object?)user.NoTelepon ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@alamat", (object?)user.Alamat ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", user.IdUser);
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<User> GetAllAdmin()
        {
            const string sql = "SELECT * FROM users WHERE role = 'Admin' ORDER BY id_user";
            return GetUsersByQuery(sql);
        }

        public List<User> GetAllPelanggan()
        {
            const string sql = "SELECT * FROM users WHERE role = 'Pelanggan' ORDER BY id_user";
            return GetUsersByQuery(sql);
        }

        public bool EmailExists(string email)
        {
            const string sql = "SELECT COUNT(1) FROM users WHERE LOWER(email) = LOWER(@email)";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
        }

        private List<User> GetUsersByQuery(string sql)
        {
            var users = new List<User>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                users.Add(MapUser(reader));
            return users;
        }
    }
}
