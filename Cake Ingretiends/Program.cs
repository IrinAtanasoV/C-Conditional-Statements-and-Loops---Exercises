using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingretiends
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ingredient = Console.ReadLine();
            int count = 0;


            

            

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");

                ingredient = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");










        }
    }
}
