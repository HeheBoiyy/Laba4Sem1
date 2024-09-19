using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_лаба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> num = new List<int> { 2,3,8,3,9,4,5};
            Func(num);
        }
        static void Func(List<int> num)
        {
            int len = num.Count;
            int min = 1000;
            int max = -10000;
           foreach(int number in num)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max) { 
                    max = number;
                }
            }
           int res = Mult(min, max);
            Console.WriteLine($"Результат {res}");
            Console.ReadLine();
        }
        static int Mult(int a,int b)
        {
            return a * b;
        }
    }   
}
