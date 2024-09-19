using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            bool isValid = IsValid(password);
            Console.WriteLine(isValid ? "Пароль действителен" : "Пароль недействителен");
            Console.ReadLine();
        }

        static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.Length > 12)
            {
                return false;
            }

            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.IndexOfAny("!@#$%^&*()_-+=<>?/{}|[]~`',.;:\"".ToCharArray()) > -1;

            return hasLower && hasUpper && hasDigit && hasSpecial;
        }
    }
}
