using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                double result = number1 / number2;

                Console.WriteLine($"Result: {number1} / {number2} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                throw new Exception();
                //Console.WriteLine("Error: Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("final block with errors");
            }

        }

    }
}
    

