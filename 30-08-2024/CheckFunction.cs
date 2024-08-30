using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFunction
{
    internal class Program
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void Check(int[] numbers, Predicate<int> condition)
        {
            foreach (var num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Odd Numbers:");
            Check(numbers, IsOdd);  // Output: 1, 3, 5, 7, 9

            Console.WriteLine("\nEven Numbers:");
            Check(numbers, IsEven);  // Output: 2, 4, 6, 8, 10
        }
    }
}

