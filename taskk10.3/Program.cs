using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int a = 1;
            int b = 1;

            while (a <= n)
            {
                sum += a;
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine($"Сумма всех чисел Фибоначчи, не превосходящих {n}: {sum}");

            Console.ReadKey();
        }
    }
}
    
