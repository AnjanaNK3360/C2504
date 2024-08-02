using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFibonacciWhile
{
    internal class P4Q11
    {
        static void PrintfibonacciSeriesWhile(int numOfTerms)
        {
            int term1 = 0;
            int term2 = 1;
            Console.Write(term1 + " ");
            Console.Write(term2 + " ");
            int I = 1;
            while (I <= numOfTerms)

            {
                int next = term1 + term2;
                Console.Write($"{next} ");
                term1 = term2;
                term2 = next;
                I++;
            }
        }
        static void TestPrintfibonacciSeriesWhile()
        {
            Console.Write("Enter number of terms:");
            int numOfTerms = int.Parse(Console.ReadLine());
            Console.Write("Series: ");
            PrintfibonacciSeriesWhile(numOfTerms);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------TestPrintfibonacciSeriesWhile().--------------");
            TestPrintfibonacciSeriesWhile();
            Console.WriteLine("--------------End TestPrintfibonacciSeriesWhile()--------------");

        }
    }
}
