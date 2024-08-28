using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "   This is some text.     ";
            Console.WriteLine(data.Trim());
            Console.WriteLine(data.TrimStart());
            Console.WriteLine(data.TrimEnd());

            Console.WriteLine(data.StartsWith(" "));
            Console.WriteLine(data.EndsWith("."));

            Console.WriteLine(data.Contains(" "));
            Console.WriteLine(data.Remove(0, 3));

            Console.WriteLine(data.Replace(" ", "_"));
            Console.WriteLine(data.IndexOf("text."));

            Console.WriteLine(data.Contains("is"));
            Console.WriteLine(data.Split(' '));
            //Remove extra space; replace spaces with _,replace text with data
            data = data.Trim()
                .Replace(" ", "_")
                .Replace("text", "data");
            Console.WriteLine(data);

            string[] arr = { "One", "Two", "Three" };
            Console.WriteLine(string.Concat(arr));
            Console.WriteLine(string.Join(",", arr));


            var numbers = new int[] { 1, 2, 3 };
           // var numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length - 1]);
            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.First());

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.OrderBy(m => m));
            Console.WriteLine(numbers.OrderByDescending(m => m));

           // Array.Sort(numbers, );

            Array.Resize(ref numbers, 10);
            numbers[3] = 500;

           // Taking largest from the first 5 elements of an array, and smallest from last 5 elements
            //var a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var largest = a.Take(5).Max();
            //var smallest = a.Skip(5).Min();
            //Console.WriteLine(largest);
            //Console.WriteLine(smallest);

           // int[] arr = { 1, 2, 3, 4, 5 };
            //List<int> myList = new List<int>(arr);

            //var arr = new int[] { 1, 2, 3, 4, 5 };
            //var lst = arr.ToList();
            //Console.WriteLine(arr);
            //Console.WriteLine(string.Join(",", lst));


            //string s = "Anjana";
            //var l = s.ToArray().ToList();
            //Console.WriteLine(s);
            //Console.WriteLine(string.Join(" ,", l);

            //var a = "abcdef";
            //var b = "eghijklabcd";

            //foreach (var chr in a)
            //{
            //    foreach (var chr2 in b)
            //    {
            //        if (chr == chr2)
            //        {
            //            Console.WriteLine("Common characters:");
            //            Console.WriteLine(chr);
            //        }
            //    }
            //}
            ///


            // var noDup = b.Distinct().ToArray();

            var a = "abcdef";
            var b = "eghijklabcd";
            var largest = a.Length > b.Length ? a : b;
            var smallest = a.Length < b.Length ? a : b;

            var withoutDups = string.Empty; // empty string

            foreach(var item in largest)
            {
                if(!withoutDups.Contains(item))
                    withoutDups += item;
            }

            foreach(var item in withoutDups)
            {
                if (smallest.Contains(item))
                {
                    Console.WriteLine($"Found: { item}");
                }
            }
        }
    }
}
