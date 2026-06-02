using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Helpers
{
    public static class RequestStatusHelper
    {
        public static string GetStatusName(
            int status)
        {
            switch (status)
            {
                case 1:
                    return "Новая";

                case 2:
                    return "В работе";

                case 3:
                    return "Завершена";

                default:
                    return "";
            }
        }
    }
}