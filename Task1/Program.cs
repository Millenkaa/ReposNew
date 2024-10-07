using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Парус (Белеет парус одинокий)");

                Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Белеет парус одинокой");
            Console.WriteLine("В тумане моря голубом!..");
            Console.WriteLine("Что ищет он в стране далекой?");
            Console.WriteLine("Что кинул он в краю родном?..");
            Console.WriteLine("Играют волны — ветер свищет,");
            Console.WriteLine("И мачта гнется и скрыпит…");
            Console.WriteLine("Увы! он счастия не ищет");
            Console.WriteLine("И не от счастия бежит!");
            Console.WriteLine("Под ним струя светлей лазури,");
            Console.WriteLine("Над ним луч солнца золотой…");
            Console.WriteLine("А он, мятежный, просит бури,");
            Console.WriteLine("Как будто в бурях есть покой!");
            
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("М.Ю.Лермонтов");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
