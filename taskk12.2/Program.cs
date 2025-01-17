using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            Console.WriteLine("Индексы строк и значения сумм четных элементов:");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                int sumEvenElements = 0;
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (array[row, col] % 2 == 0)
                    {
                        sumEvenElements += array[row, col];
                    }
                }
                Console.WriteLine($"Строка {row + 1}: сумма = {sumEvenElements}");
            }
        }
    }
}
    
