using System;

namespace MedicalDeskLib.DTO
{
    public class EquipmentGridDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string InventoryNumber { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}