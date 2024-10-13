using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = F(2, 3) + F(7, 8) + F(1, 4);
            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }
        static double F(double a, double b)
        {
            return Math.Sqrt(a + Math.Tan(b) / Math.Pow(a, 2)) + Math.Pow(b, 2);
        }
    }
}
    
