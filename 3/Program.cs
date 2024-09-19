using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Maxi(input));
            Console.ReadLine();
        }
        static string Maxi(string str)
        {
            int maxim = -1000;
            string res = "";
            string[] words = str.Split(new char[] {' '});
            foreach (string word in words)
            {
                if (word.Length > maxim)
                {
                    maxim = word.Length;
                    res = word;
                }
            }
            return res;
        }
    }
}
