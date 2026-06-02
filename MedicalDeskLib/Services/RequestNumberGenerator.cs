using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Services
{
    public static class RequestNumberGenerator
    {
        public static string Generate(
            int id)
        {
            return
                "REQ-" +
                id.ToString("D6");
        }
    }
}