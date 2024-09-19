using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var BD = new Dictionary<string, int> {
           {"Маша",10000},
           {"Паша",30000},
           {"Вася",100000}

           };
            Console.WriteLine("Введите своё имя пользователя и сумму которую хотите внести");
            string user = Console.ReadLine();
            int deneg = int.Parse(Console.ReadLine());
            if (BD.ContainsKey(user))
            {
                BD[user] += deneg;
                Console.WriteLine($"{user}, ваш баланс изменён! Текущий баланс: {BD[user]}");
            }
            else
            {
                BD.Add(user, deneg);
                Console.WriteLine($"{user}, Благодарим, что вы стали клиентом нашего банка! Ваш баланс изменён! Текущий баланс: {BD[user]}"); 
            }
            Console.WriteLine($"Вы можете воспользоваться стандартным вкладом нашего банка! Вложив сумму остатка {BD[user]} на 3 года под 17% годовых. Вы получите прибыль" +
                $" {Zarab(BD[user])} руб. Для активации вклада войдите в мобильное приложение ");
            Console.ReadLine();
            double Zarab(int den)
            {
                den = BD[user];
                return den * Math.Pow(1.17, 3);
            }


        }

    }
    
}
