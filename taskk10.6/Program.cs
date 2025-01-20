using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b (должно быть больше a): ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение k (2 ≤ k ≤ 10): ");
            int k = int.Parse(Console.ReadLine());

            if (a >= b(k > 10))
            {
                Console.WriteLine("Ошибка ввода данных. Убедитесь, что a < b и 2 ≤ k ≤ 10.");
                return;
            }

            Console.WriteLine($"Целые числа из промежутка от {a} до {b}, у которых сумма делителей кратна {k}:");

            for (int i = a; i <= b; i++)
            {
                int sumOfDivisors = CalculateSumOfDivisors(i);

                if (sumOfDivisors % k == 0)
                {
                    Console.WriteLine($"{i} (сумма делителей: {sumOfDivisors})");
                }
            }
        }

        static int CalculateSumOfDivisors(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }


            sum += number;

            return sum;
        }
    }
}
