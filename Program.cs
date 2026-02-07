using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 gredes seperated by new line: ");

            double[] grades = new double[5];
            double sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToDouble(Console.ReadLine());
                sum += grades[i];
            }
            double average = sum / grades.Length;

            double roundedAverage = Math.Round(average);

            Console.WriteLine("The average of the grades is: " + average);
            Console.WriteLine("The rounded average of the grades is: " + roundedAverage);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
