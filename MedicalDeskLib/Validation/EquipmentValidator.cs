using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Validation
{
    public static class EquipmentValidator
    {
        public static string Validate(
            string name,
            string model,
            string inventoryNumber,
            string location)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Введите наименование";

            if (string.IsNullOrWhiteSpace(model))
                return "Введите модель";

            if (string.IsNullOrWhiteSpace(inventoryNumber))
                return "Введите инвентарный номер";

            if (string.IsNullOrWhiteSpace(location))
                return "Введите местоположение";

            return null;
        }
    }
}