using MedicalDeskLib.Data;
using MedicalDeskLib.Models;
using MedicalDeskLib.Security;
using MySql.Data.MySqlClient;

namespace MedicalDeskLib.Services
{
    public class AuthService
    {
        public User Login(
            string login,
            string password)
        {
            using (var connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                    @"SELECT * FROM Users
                      WHERE Login=@Login
                      AND IsActive=1";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@Login",
                    login);

                MySqlDataReader reader =
                    command.ExecuteReader();

                if (!reader.Read())
                    return null;

                string hash =
                    reader["PasswordHash"]
                    .ToString();

                bool valid =
                    PasswordHasher.Verify(
                        password,
                        hash);

                if (!valid)
                    return null;

                User user = new User();

                user.Id =
                    (int)reader["Id"];

                user.Login =
                    reader["Login"].ToString();

                user.FullName =
                    reader["FullName"].ToString();
                user.Phone =
    reader["Phone"].ToString();
                user.Role =
                    (int)reader["Role"];

                return user;
            }
        }
    }
}