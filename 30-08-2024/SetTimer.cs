using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SetTimer
{
    public delegate void Operation();
    internal class Program
    {
        public static void DoThis() => Console.WriteLine("Hello");

        public static void SetTimer(int delay,Operation op)
        {
            Thread.Sleep(delay);
            op();
        }
        static void Main(string[] args)
        {
            SetTimer(5000, DoThis);
        }
    }
}
