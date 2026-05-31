using System;

namespace MedicalDeskLib.Models
{
    public class RequestHistory
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public string Comment { get; set; }
        public int OldStatus { get; set; }
        public int NewStatus { get; set; }
        public int ChangedByUserId { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}