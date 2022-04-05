// Вывести квадрат числа

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_00_squared_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter a number: ");
            double inpt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The squared number: " + Math.Round(Math.Pow(inpt, 2), 4));

            Console.ReadLine();
        }
    }
}