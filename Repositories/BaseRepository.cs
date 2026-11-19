using Npgsql;

namespace KalaRintikTea.Repositories
{

    public abstract class BaseRepository
    {
        protected NpgsqlConnection CreateConnection()
        {
            return DbConnectionFactory.CreateConnection();
        }

        protected NpgsqlCommand CreateCommand(string sql, NpgsqlConnection conn)
        {
            return new NpgsqlCommand(sql, conn);
        }
    }
}
