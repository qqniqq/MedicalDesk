using MedicalDeskLib.Data;
using MedicalDeskLib.DTO;
using MedicalDeskLib.Helpers;
using MedicalDeskLib.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
        public List<EquipmentGridDto> GetGridData()
        {
            List<EquipmentGridDto> result =
                new List<EquipmentGridDto>();

            List<Equipment> items =
                GetAll();

            foreach (Equipment equipment in items)
            {
                EquipmentGridDto dto =
                    new EquipmentGridDto();

                dto.Id =
                    equipment.Id;

                dto.Name =
                    equipment.Name;

                dto.Model =
                    equipment.Model;

                dto.InventoryNumber =
                    equipment.InventoryNumber;

                dto.Location =
                    equipment.Location;

                dto.Status =
                    EquipmentStatusHelper.GetStatusName(
                        equipment.Status);

                dto.CreatedAt =
                    equipment.CreatedAt;

                result.Add(dto);
            }

            return result;
        }
        //ПОЛУЧЕНИЕ ОБОРУДОВАНИЯ ДЛЯ COMBOBOX 
        public Equipment GetById(
    int id)
        {
            using (MySqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM Equipment WHERE Id=@Id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@Id",
                    id);

                MySqlDataReader reader =
                    command.ExecuteReader();

                if (!reader.Read())
                    return null;

                Equipment equipment =
                    new Equipment();

                equipment.Id =
                    reader.GetInt32("Id");

                equipment.Name =
                    reader.GetString("Name");

                return equipment;
            }
        }

        public List<Equipment> GetAllSimple()
        {
            return GetAll();
        }
    }
}