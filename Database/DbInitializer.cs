using System;
using System.IO;
using Npgsql;
using KalaRintikTea.Helpers;

namespace KalaRintikTea.Database
{
    public static class DbInitializer
    {
        public static bool Initialize(out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using var conn = new NpgsqlConnection(AppConfig.ConnectionString);
                conn.Open();

                // Check if users table already exists
                const string checkSql = "SELECT COUNT(*) FROM information_schema.tables WHERE table_name = 'users'";
                using var checkCmd = new NpgsqlCommand(checkSql, conn);
                long tableCount = Convert.ToInt64(checkCmd.ExecuteScalar());

                if (tableCount == 0)
                {
                    // Find schema.sql file
                    string schemaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "schema.sql");
                    if (!File.Exists(schemaPath))
                    {
                        // Try alternative path from project root
                        schemaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Database", "schema.sql");
                    }

                    if (File.Exists(schemaPath))
                    {
                        string ddl = File.ReadAllText(schemaPath);
                        using var ddlCmd = new NpgsqlCommand(ddl, conn);
                        ddlCmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
