using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFiboDoWhile
{
    internal class Program
    {
        static void PrintfiboDoWhile(int numOfTerms)
        {
            int term1 = 0;
            int term2 = 1;
            Console.Write(term1 + " ");
            Console.Write(term2 + " ");
            int I = 1;
            do
            {
                int next = term1 + term2;
                Console.Write($"{next} ");
                term1 = term2;
                term2 = next;
                I++;

            } while (I <= numOfTerms);
        }
        static void TestPrintfiboDoWhile()
        {
            Console.Write("Enter number of terms:");
            int numOfTerms = int.Parse(Console.ReadLine());
            Console.Write("Series: ");
            PrintfiboDoWhile(numOfTerms);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------TestPrintfibonacciSeriesDoWhile().--------------");
            TestPrintfiboDoWhile();
            Console.WriteLine("--------------End TestPrintfibonacciSeriesDoWhile()--------------");

        }
    }
}
