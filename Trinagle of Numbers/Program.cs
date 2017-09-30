using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinagle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int b = 1; b <= count; b++)
                {
                    Console.Write($"{count} ");
                }
                Console.WriteLine();

                count++;
            }



        }
    }
}
