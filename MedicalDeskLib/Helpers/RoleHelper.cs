using MedicalDeskLib.Enums;

namespace MedicalDeskLib.Helpers
{
    public static class RoleHelper
    {
        public static string GetRoleName(int role)
        {
            switch ((UserRole)role)
            {
                case UserRole.Administrator:
                    return "Администратор";

                case UserRole.Technician:
                    return "Технический специалист";

                case UserRole.User:
                    return "Пользователь";

                default:
                    return "";
            }
        }
    }
}