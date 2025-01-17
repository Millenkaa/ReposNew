using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p0 = 1.29;
            const double C = 1.25e-4;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите значение n (10 ≤ n ≤ 100): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 10 || n > 100)
            {
                Console.WriteLine("Число n должно быть в пределах от 10 до 100.");
                return;
            }

            Console.WriteLine("Таблица зависимости плотности воздуха от высоты:");
            Console.WriteLine("Высота (м)\tПлотность воздуха (кг/м³)");

            for (int i = 0; i <= n * 100; i += 100)
            {
                double height = i; // Высота в метрах 
                double density = p0 * Math.Exp(-C * height);
                Console.WriteLine($"{height}\t\t{density:F3}");
            }
        }
    }
}
    

