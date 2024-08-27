using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var arr = new int[] { 1, 4, 5, 6, 8 };
            foreach ( var item in arr )
            {
                Console.WriteLine(item);
            }
            */
            string str = " Hello World";
            foreach (char s in str)
            {
                char res = char.ToUpper(s);
                Console.Write(res);
            }
        }
    }
}
