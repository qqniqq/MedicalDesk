using System;
using System.Collections.Generic;
using MedicalDeskLib.Data;
using MedicalDeskLib.Models;
using MySql.Data.MySqlClient;

namespace MedicalDeskLib.Repositories
{
    public class EquipmentRepository
    {
        public List<Equipment> GetAll()
        {
            List<Equipment> equipmentList =
                new List<Equipment>();

            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM Equipment";

                MySqlCommand command =
                    new MySqlCommand(query, connection);

                MySqlDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    Equipment equipment =
                        new Equipment();

                    equipment.Id =
                        reader.GetInt32("Id");

                    equipment.Name =
                        reader.GetString("Name");

                    equipment.Model =
                        reader.GetString("Model");

                    equipment.InventoryNumber =
                        reader.GetString("InventoryNumber");

                    equipment.Location =
                        reader.GetString("Location");

                    equipment.Status =
                        reader.GetInt32("Status");

                    equipmentList.Add(equipment);
                }
            }

            return equipmentList;
        }

        public void Add(
            Equipment equipment)
        {
            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO Equipment
                (
                    Name,
                    Model,
                    InventoryNumber,
                    Location,
                    Status,
                    CreatedAt
                )
                VALUES
                (
                    @Name,
                    @Model,
                    @InventoryNumber,
                    @Location,
                    @Status,
                    @CreatedAt
                )";

                MySqlCommand command =
                    new MySqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@Name",
                    equipment.Name);

                command.Parameters.AddWithValue(
                    "@Model",
                    equipment.Model);

                command.Parameters.AddWithValue(
                    "@InventoryNumber",
                    equipment.InventoryNumber);

                command.Parameters.AddWithValue(
                    "@Location",
                    equipment.Location);

                command.Parameters.AddWithValue(
                    "@Status",
                    equipment.Status);

                command.Parameters.AddWithValue(
                    "@CreatedAt",
                    equipment.CreatedAt);

                command.ExecuteNonQuery();
            }
        }
    }
}