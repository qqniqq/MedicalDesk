using System;

namespace MedicalDeskLib.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string InventoryNumber { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}