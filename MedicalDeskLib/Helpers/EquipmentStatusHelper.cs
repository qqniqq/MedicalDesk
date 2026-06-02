using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Helpers
{
    public static class EquipmentStatusHelper
    {
        public static string GetStatusName(int status)
        {
            switch (status)
            {
                case 1:
                    return "Работает";

                case 2:
                    return "На ремонте";

                case 3:
                    return "Списано";

                default:
                    return "";
            }
        }
    }
}