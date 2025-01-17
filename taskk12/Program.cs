using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            if (AreColumnsSorted(array, out int rowIndex, out int colIndex))
            {
                Console.WriteLine("Элементы столбцов массива упорядочены по возрастанию.");
            }
            else if (AreRowsSortedDescending(array, out rowIndex, out colIndex))
            {
                Console.WriteLine("Элементы строк массива упорядочены по убыванию.");
            }
            else
            {
                Console.WriteLine($"Нарушение порядка: строка {rowIndex + 1}, столбец {colIndex + 1}");
            }
        }

        static bool AreColumnsSorted(int[,] array, out int rowIndex, out int colIndex)
        {
            rowIndex = -1;
            colIndex = -1;

            for (int col = 0; col < array.GetLength(1); col++)
            {
                for (int row = 1; row < array.GetLength(0); row++)
                {
                    if (array[row, col] < array[row - 1, col])
                    {
                        rowIndex = row;
                        colIndex = col;
                        return false;
                    }
                }
            }

            return true;
        }

        static bool AreRowsSortedDescending(int[,] array, out int rowIndex, out int colIndex)
        {
            rowIndex = -1;
            colIndex = -1;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 1; col < array.GetLength(1); col++)
                {
                    if (array[row, col] > array[row, col - 1])
                    {
                        rowIndex = row;
                        colIndex = col;
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
    

