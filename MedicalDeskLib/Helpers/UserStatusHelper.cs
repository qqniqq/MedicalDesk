using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Helpers
{
    public static class UserStatusHelper
    {
        public static string GetStatus(bool active)
        {
            return active
                ? "Активен"
                : "Заблокирован";
        }
    }
}
