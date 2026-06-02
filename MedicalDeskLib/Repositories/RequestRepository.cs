using System;
using System.Collections.Generic;

using MedicalDeskLib.Data;
using MedicalDeskLib.Models;

using MySql.Data.MySqlClient;

namespace MedicalDeskLib.Repositories
{
    public class RequestRepository
    {
        //СОЗДАНИЕ ЗАЯВКИ
        public void Add(Request request)
        {
            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO Requests
        (
            RequestNumber,
            Description,
            Status,
            CreatedAt,
            UserId,
            EquipmentId,
            TechnicianId
        )
        VALUES
        (
            @RequestNumber,
            @Description,
            @Status,
            @CreatedAt,
            @UserId,
            @EquipmentId,
            @TechnicianId
        )";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@RequestNumber",
                    request.RequestNumber);

                command.Parameters.AddWithValue(
                    "@Description",
                    request.Description);

                command.Parameters.AddWithValue(
                    "@Status",
                    request.Status);

                command.Parameters.AddWithValue(
                    "@CreatedAt",
                    request.CreatedAt);

                command.Parameters.AddWithValue(
                    "@UserId",
                    request.UserId);

                command.Parameters.AddWithValue(
                    "@EquipmentId",
                    request.EquipmentId);

                command.Parameters.AddWithValue(
                    "@TechnicianId",
                    request.TechnicianId);

                command.ExecuteNonQuery();
            }
        }
        //ПОЛУЧЕНИЕ ВСЕХ ЗАЯВОК
        public List<Request> GetAll()
        {
            List<Request> requests =
                new List<Request>();

            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM Requests";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                MySqlDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    Request request =
                        new Request();

                    request.Id =
                        reader.GetInt32("Id");

                    request.RequestNumber =
                        reader.GetString(
                            "RequestNumber");

                    request.Description =
                        reader.GetString(
                            "Description");

                    request.Status =
                        reader.GetInt32(
                            "Status");

                    request.CreatedAt =
                        reader.GetDateTime(
                            "CreatedAt");

                    request.UserId =
                        reader.GetInt32(
                            "UserId");

                    request.EquipmentId =
                        reader.GetInt32(
                            "EquipmentId");

                    if (!reader.IsDBNull(
                        reader.GetOrdinal(
                            "TechnicianId")))
                    {
                        request.TechnicianId =
                            reader.GetInt32(
                                "TechnicianId");
                    }

                    requests.Add(request);
                }
            }

            return requests;
        }

        public int GetNextId()
        {
            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                    "SELECT IFNULL(MAX(Id),0)+1 FROM Requests";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                return Convert.ToInt32(
                    command.ExecuteScalar());
            }
        }
    }
}