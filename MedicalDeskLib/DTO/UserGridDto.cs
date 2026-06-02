using System;

namespace MedicalDeskLib.DTO
{
    public class UserGridDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}