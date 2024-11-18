using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "программа";
            Console.WriteLine(word,"Из слова \"{word}\" получили: ");

            string word1 = word.Substring(0, 1) + word.Substring(5, 1) + word.Substring(4, 1);

            string word2 = word.Substring(4, 3) + word.Substring(0, 1) + word.Substring(5, 1);

                Console.WriteLine("Первое слово: " + word1);
            Console.WriteLine("Второе слово: " + word2);

           

            Console.ReadKey();

        }
    }
}
