// Даны два числа. Показать большее и меньшее число

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02_bigger_smaller_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter the first number: ");
            int nmbr1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int nmbr2 = int.Parse(Console.ReadLine());

            if (nmbr1 > nmbr2)
            {
                Console.WriteLine($"{nmbr1} > {nmbr2}");
            }
            else
            {
                Console.WriteLine($"{nmbr1} < {nmbr2}");
            }
            Console.ReadKey();
        }
    }
}