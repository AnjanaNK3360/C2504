using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SetTimerV2
{
    //public delegate void Operation();
    internal class Program
    {
        public static void DoThis() => Console.WriteLine("Hello");

        public static void SetTimer(int delay, Action callback)
        {
            Thread.Sleep(delay);
            callback();
        }
        static void Main(string[] args)
        {
            SetTimer(5000, DoThis);
        }
    }
}
