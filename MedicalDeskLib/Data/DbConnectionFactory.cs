using MySql.Data.MySqlClient;

namespace MedicalDeskLib.Data
{
    public static class DbConnectionFactory
    {
        private static readonly string ConnectionString =
            "server=localhost;" +
            "database=medicaldesk;" +
            "uid=root;" +
            "pwd=vertrigo;" +
            "charset=utf8mb4;";

        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}