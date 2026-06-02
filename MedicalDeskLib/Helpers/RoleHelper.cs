using MedicalDeskLib.Enums;

namespace MedicalDeskLib.Helpers
{
    public static class RoleHelper
    {
        public static string GetRoleName(int role)
        {
            switch ((UserRole)role)
            {
                case UserRole.User:
                    return "Пользователь";

                case UserRole.Technician:
                    return "Технический специалист";

                case UserRole.Administrator:
                    return "Администратор";

                default:
                    return "";
            }
        }
    }
}