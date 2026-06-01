using MedicalDeskLib.Models;

namespace MedicalDeskLib.Security
{
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }
    }
}