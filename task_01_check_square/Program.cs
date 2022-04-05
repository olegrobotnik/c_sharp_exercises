// По двум заданным числам проверять является ли первое квадратом второго

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01_check_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter the first number: ");
            double numOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            if (numOne == Math.Pow(numTwo, 2))
            {
                Console.WriteLine(numOne + " is the square of the " + numTwo);
            }
            else
            {
                Console.WriteLine("It's not a square of " + numTwo);
            }
        }
    }
}
