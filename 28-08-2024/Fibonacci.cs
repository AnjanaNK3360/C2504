using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        //0 1 1 2 3 5 8 13.......
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms");
            int N = int.Parse(Console.ReadLine());
            int term1 = 0;
            int term2 = 1;
            int term3 = 0;

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{i}\t");
                }
                else if(i == 1)
                {
                    Console.Write($"{i}\t");
                }
                else
                {
                    term3 = term1 + term2;
                    Console.Write($"{term3}\t");
                    term1 = term2;
                    term2 = term3;
                }
            }

        }
    }
}
