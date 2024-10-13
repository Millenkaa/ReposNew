using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите первый катет прямоугольного треугольника: ");
                double kat1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второй катет прямоугольного треугольника: ");
                double kat2 = Convert.ToDouble(Console.ReadLine());

                double perimeter = (Math.Sqrt((kat1 * kat1) + (kat2 * kat2)) + kat1 + kat2);

                double area = (kat1 * kat2) / 2;

                Console.WriteLine($"Периметр: {perimeter}");
                Console.WriteLine($"Площадь: {area}");
            Console.ReadKey();
            }
        }
   
}
