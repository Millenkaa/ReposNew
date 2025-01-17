using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число сотрудников: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            double totalSalary = 0;

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Введите зарплату сотрудника {i}: ");
                double salary = double.Parse(Console.ReadLine());
                totalSalary += salary;
            }

            Console.WriteLine($"Общая сумма выплаченных по ведомости денег: {totalSalary:F2} рублей");

            Console.ReadKey();
        }
    }
}
    

