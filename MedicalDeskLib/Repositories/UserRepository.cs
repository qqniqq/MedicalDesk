using System.Collections.Generic;
using MedicalDeskLib.Data;
using MedicalDeskLib.Models;
using MySql.Data.MySqlClient;

namespace MedicalDeskLib.Repositories
{
    public class UserRepository
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Users";

                MySqlCommand command =
                    new MySqlCommand(query, connection);

                MySqlDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();

                    user.Id =
                        reader.GetInt32("Id");

                    user.Login =
                        reader.GetString("Login");

                    user.FullName =
                        reader.GetString("FullName");

                    user.Role =
                        reader.GetInt32("Role");

                    user.IsActive =
                        reader.GetBoolean("IsActive");

                    users.Add(user);
                }
            }
            return users;
        }
        public void Add(User user)
        {
            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO Users
        (
            Login,
            PasswordHash,
            FullName,
            Role,
            CreatedAt,
            IsActive
        )
        VALUES
        (
            @Login,
            @PasswordHash,
            @FullName,
            @Role,
            @CreatedAt,
            @IsActive
        )";

                MySqlCommand command =
                    new MySqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@Login",
                    user.Login);

                command.Parameters.AddWithValue(
                    "@PasswordHash",
                    user.PasswordHash);

                command.Parameters.AddWithValue(
                    "@FullName",
                    user.FullName);

                command.Parameters.AddWithValue(
                    "@Role",
                    user.Role);

                command.Parameters.AddWithValue(
                    "@CreatedAt",
                    user.CreatedAt);

                command.Parameters.AddWithValue(
                    "@IsActive",
                    user.IsActive);

                command.ExecuteNonQuery();
            }
        }

    }
}