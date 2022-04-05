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

            int nmbr1 = 0;
            int nmbr2 = 0;
           
            nmbr1 = GetIntNmbr("Enter the first number: ");
            nmbr2 = GetIntNmbr("Enter the second number: ");
            
            if (nmbr1 > nmbr2)
            {
                Console.WriteLine($"{nmbr1} > {nmbr2}");
            }
            else if (nmbr1 < nmbr2)
            {
                Console.WriteLine($"{nmbr1} < {nmbr2}");
            }
            else
            {
                Console.WriteLine($"{nmbr1} = {nmbr2}");
            }
            Console.ReadKey();

            int GetIntNmbr(string msg)  // Integer console input method
            {
                int outpt = 0;
                bool rslt = false;
                
                while (rslt == false)
                {
                    Console.Write(msg);
                    rslt = int.TryParse(Console.ReadLine(), out outpt);
                }   
                return outpt;
            }
        }
    }
}