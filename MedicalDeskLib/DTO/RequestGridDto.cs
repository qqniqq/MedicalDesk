using System;

namespace MedicalDeskLib.DTO
{
    public class RequestGridDto
    {
        public string RequestNumber { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}