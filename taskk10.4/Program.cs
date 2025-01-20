using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите последовательность целых чисел, оканчивающуюся нулем (вводите каждое число последовательности через Enter):");

            int countEvenNumbers = 0;
            while (true)
            {
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Пожалуйста, введите корректное целое число.");
                    continue;
                }

                if (number == 0)
                    break;

                if (number % 2 == 0)
                    countEvenNumbers++;
            }

            Console.WriteLine($"Количество всех четных чисел последовательности: {countEvenNumbers}");

            Console.ReadKey();
        }
    }
}
    
