using Npgsql;
using KalaRintikTea.Helpers;

namespace KalaRintikTea.Repositories
{

    public static class DbConnectionFactory
    {
        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(AppConfig.ConnectionString);
        }
    }
}
