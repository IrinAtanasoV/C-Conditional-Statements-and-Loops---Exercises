﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());


            if (profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {(quantity * 0.70):F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {(quantity * 1.00):F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {(quantity * 1.70):F2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {(quantity * 1.20):F2}.");
            }
        }
    }
}
