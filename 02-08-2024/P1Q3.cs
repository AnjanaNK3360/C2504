﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSeriesDoWhile
{
    internal class P1Q3
    {
        static void PrintSeries10_12_14(int numOfTerms)
        {
            int term = 10;
            int I = 1;
            do
            {
                if (0 == numOfTerms)
                {
                    break;
                }
                Console.Write($"{term} ");
                term = term + 2;

                I++;
            } while (I <= numOfTerms);
        }
        // input=5, output=10 12 14 16 18
        // input=8, output=10 12 14 16 18 20 22 24
        // input=3, output=10 12 14
        // input=0, ouput=
        static void TestPrintSeries10_12_14()
        {
            Console.Write("Enter number of terms:");
            int numOfTerms = int.Parse(Console.ReadLine());
            Console.Write("Series: ");
            PrintSeries10_12_14(numOfTerms);
            Console.WriteLine();
        }

        static void Main(string[] args) //user: p
        {
            Console.WriteLine("--------------TestPrintSeries10_12_14...--------------");
            TestPrintSeries10_12_14();
            Console.WriteLine("--------------End TestPrintSeries10_12_14...--------------");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
