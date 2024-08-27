using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Program
    {
        public static (string Upper, string Lower) ToUpperAndLower(string input) //  public static (string, string) ToUpperAndLower(string input)
        {
            var upper = input.ToUpper();
            var lower = input.ToLower();
            return (upper, lower);
        }
        static void Main(string[] args)
        {
            var res = ToUpperAndLower("Hello World");
            Console.WriteLine(res.Upper);// Console.WriteLine(res.Item1);
            Console.WriteLine(res.Lower);//Console.WriteLine(res.Item2);
        }
    }
}
