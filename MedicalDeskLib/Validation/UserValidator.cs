using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDeskLib.Validation
{
    public static class UserValidator
    {
        public static string Validate(
            string fullName,
            string login,
            string password)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return "Введите ФИО";

            if (string.IsNullOrWhiteSpace(login))
                return "Введите логин";

            if (string.IsNullOrWhiteSpace(password))
                return "Введите пароль";

            if (password.Length < 6)
                return "Минимальная длина пароля 6 символов";

            return null;
        }
    }
}
