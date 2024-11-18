using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число : ");
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int n) && n >= 100 && n <= 999)
            {
                int x = FindX(n);
                Console.WriteLine($"Полученное число: {x}");
            }
            else
            {
                Console.WriteLine("Введенное число не соответствует условиям задачи.");

            }
            Console.ReadKey();
        }

        static int FindX(int n)
        {
            string nStr = n.ToString();
            char firstDigit = nStr[0];
            char secondDigit = nStr[1];
            char thirdDigit = nStr[2];
            string xStr = thirdDigit.ToString() + firstDigit.ToString() + secondDigit.ToString();

            return int.Parse(xStr);
            
        }
    }
}
