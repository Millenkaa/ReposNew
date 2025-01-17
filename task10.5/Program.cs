using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            int alternatingSum = CalculateAlternatingSum(number);

            Console.WriteLine($"Знакочередующаяся сумма цифр числа: {alternatingSum}");

            Console.ReadKey();
        }

        static int CalculateAlternatingSum(int number)
        {
            int alternatingSum = 0;
            int sign = 1;

            while (number > 0)
            {
                int digit = number % 10;
                alternatingSum += sign * digit;
                sign = -sign;
                number /= 10;
            }

            return alternatingSum;
        }
    }
}
    
