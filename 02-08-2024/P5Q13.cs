using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNthTermFibo
{
    internal class P5Q13
    {
        static int GetNthTermFibo(int N)
        {
            int next = 0;
            int term1 = 0;
            int term2 = 1;
            
            //for (int I = 3; I <= N; I++)
            //{
                if (N == 1)
                {
                    next = term1;
                    //Console.WriteLine(term1);


                }
                else if (N == 2)
                {
                    next = term2;
                    //Console.WriteLine(term2);
                    //break;
                }
                for (int I = 3; I <= N; I++)
                {

                    // { 
                    next = term1 + term2;
                    //Console.WriteLine(next);
                    term1 = term2;
                    term2 = next;
                //}
                }
           // }
            return next;
        }

        static void TestGetNthTermFibo()
        {
            Console.Write("Enter number of terms:");
            int N = int.Parse(Console.ReadLine());
            int nthTerm = GetNthTermFibo(N);
            Console.WriteLine($"Nth term is {nthTerm}");
        }
        static void Main(string[] args) //user: p
        {
            Console.WriteLine("-----TestGetNthTerm----");
            TestGetNthTermFibo();
            Console.WriteLine("-----End TestGetNthTerm_-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
