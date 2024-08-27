using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] studentMarks = {
        { 80, 70, 90 },
        { 90, 80, 70 },
        { 70, 90, 80 },
        { 85, 75, 95 },
        { 95, 85, 75 }
};
            */
            var studentMarks = new (int English, int Malayalam, int Physics)[]
            {
                ( 80, 70, 90 ),
                ( 90, 80, 70 ),
                ( 70, 90, 80 ),
                ( 85, 75, 95 ),
                ( 95, 85, 75 )
            };
            foreach ( var marks in studentMarks )
            {
                Console.WriteLine( marks.English );
                Console.WriteLine(marks.Malayalam );
                Console.WriteLine( marks.Physics );

            }
        }
    }
}
