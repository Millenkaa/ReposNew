using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            int result = F(N);
            Console.WriteLine("F(1000) = " + result);
        }

        static bool IsThreeOne(int n)
        {
            int k = 0;

            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    k++;
                    if (k == 3)
                        return true;
                }
                else
                {
                    k = 0;
                }

                n = n / 2;
            }

            return false;

        }

        static int F(int N)
        {
            int s = 0;
            int count = 0;
            int n = 1;

            while (count < N)
            {
                if (IsThreeOne(n) == false)
                {
                    count++;
                    if (n % 2 != 0)
                    {
                        s += (int)count * count;
                    }
                }
                n++;
            }

            return s;


        }
    }
}
    

