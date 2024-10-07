using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число");
            var x = double.Parse(Console.ReadLine());
            var y = MyFunction(x);
            Console.WriteLine($"F(x)={y}");
            Console.ReadKey();
               
        }
        static double MyFunction(double x)

        {
            //throw new NotImplementedException();

            return (((2) / (Math.Pow(x, 2) + 25)) + Math.Cos(x)) / (Math.Sqrt(Math.Pow(x, 4) + 1) + (Math.Sin(x) + Math.Cos(x)) / 2);
                
        
        }

    }
}
