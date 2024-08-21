using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Add(params int[] numbers)
        {
            var sum = numbers.Sum();
            Console.WriteLine(sum);
        }
        public static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 5);
            Add(1, 2, 5, 9);
     
        }
    }
}
