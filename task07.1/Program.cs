using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = GetNumber("m");
            var n = GetNumber("n");
            var k = GetNumber("k");

            if (IsStatementTrue(m, n, k))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();

        }

        static bool IsStatementTrue(int m, int n, int k)
        {
            return m < 0 && n < 0 && k < 0;

        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}