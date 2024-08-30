using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Delegates
{
    //public delegate void Operation(int n1, int n2);

    internal class Program
    {
        public static  void Add(int a, int b) => Console.WriteLine(a +  b);
        public static void Sub(int a, int b) => Console.WriteLine(a - b);
        public static long Mul(int a, int b) => (long)(a * b);
        public static bool IsEven(int x) => x % 2 == 0;


        public static void Main()
        {
            //Operation op = Add;
            //op += Sub;
            //op += Sub;
            //op -= Sub;
            //Thread.Sleep(1000);
            //op(10, 5);

            Action<int, int> x = Add; // Void return type
            Func<int, int, long> y = Mul;//Non void return type
            Func<int,bool> y1 = IsEven;// Non void return type
            Predicate<int> z = IsEven;// bool return type and single parameter

            x(4, 5);
            x(4, 5); 
            Console.WriteLine("Mul: " + y(4, 5)); 
            Console.WriteLine("IsEven (y1): " + y1(4)); 
            Console.WriteLine("IsEven (z): " + z(7));


        }
    }
}
