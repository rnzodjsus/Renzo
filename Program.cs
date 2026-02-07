using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 4;

            Console.WriteLine($"Addtion of {a} and {b}: {Add(a, b)}");
            Console.WriteLine($"Subtraction of {a} and {b}: {Subtract(a, b)}");
            Console.WriteLine($"Multiplication of {a} and {b}: {Multiply(a, b)}");
            Console.WriteLine($"Division od {a} and {b}: {Divide(a, b)}");
            Console.WriteLine($"Power of {a} and {b}: {Power(a, b)}");
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static double Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN; 
            }
            return (double)x / y;
        }
        static double Power(int baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);

            Console.ReadKey();

        }
    }
}
