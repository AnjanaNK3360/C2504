using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PrintFibonacci
{
    internal class P4Q10
    {
        static void PrintfibonacciSeries(int numOfTerms)
        {
            int term1 = 0;
            int term2 = 1;
            Console.Write(term1 +" ");
            Console.Write(term2 + " ");
            for (int I = 1; I <= numOfTerms ; I++ )
            {
                int next = term1 + term2;

                Console.Write($"{next} ");
                term1 = term2;
                term2 = next;
            }
        }
        static void TestPrintfibonacciSeries()
        {
            Console.Write("Enter number of terms:");
            int numOfTerms = int.Parse(Console.ReadLine());
            Console.Write("Series: ");
            PrintfibonacciSeries(numOfTerms);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
                Console.WriteLine("--------------TestPrintfibonacciSeries().--------------");
                TestPrintfibonacciSeries();
                Console.WriteLine("--------------End TestPrintfibonacciSeries()--------------");
             
            }
    }
}
