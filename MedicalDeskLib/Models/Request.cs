using System;

namespace MedicalDeskLib.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string RequestNumber { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
        public int UserId { get; set; }
        public int EquipmentId { get; set; }
        public int? TechnicianId { get; set; }
    }
}