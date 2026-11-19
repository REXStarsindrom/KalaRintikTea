using System;
using System.Collections.Generic;
using Npgsql;
using KalaRintikTea.Models;

namespace KalaRintikTea.Repositories
{
    public class KategoriRepository : BaseRepository, IRepository<Kategori>
    {
        public List<Kategori> GetAll()
        {
            const string sql = "SELECT id_kategori, nama_kategori FROM kategori ORDER BY id_kategori";
            var list = new List<Kategori>();
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Kategori(
                    reader.GetInt32(0),
                    reader.GetString(1)
                ));
            }
            return list;
        }

        public Kategori? GetById(int id)
        {
            const string sql = "SELECT id_kategori, nama_kategori FROM kategori WHERE id_kategori = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Kategori(reader.GetInt32(0), reader.GetString(1));
            }
            return null;
        }

        public int Add(Kategori entity)
        {
            const string sql = "INSERT INTO kategori (nama_kategori) VALUES (@nama) RETURNING id_kategori";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", entity.NamaKategori);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Update(Kategori entity)
        {
            const string sql = "UPDATE kategori SET nama_kategori = @nama WHERE id_kategori = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", entity.NamaKategori);
            cmd.Parameters.AddWithValue("@id", entity.IdKategori);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            const string sql = "DELETE FROM kategori WHERE id_kategori = @id";
            using var conn = CreateConnection();
            conn.Open();
            using var cmd = CreateCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
