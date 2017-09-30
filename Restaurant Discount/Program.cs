using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double sumOfPrice = 0;

            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                if (package == "Normal")
                {
                    sumOfPrice = 2500 + 500;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.05);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Gold")
                {
                    sumOfPrice = 2500 + 750;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.10);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Platinum")
                {
                    sumOfPrice = 2500 + 1000;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.15);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                if (package == "Normal")
                {
                    sumOfPrice = 5000 + 500;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.05);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Gold")
                {
                    sumOfPrice = 5000 + 750;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.10);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Platinum")
                {
                    sumOfPrice = 5000 + 1000;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.15);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
            }
            else if (groupSize > 100 && groupSize <=120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                if (package == "Normal")
                {
                    sumOfPrice = 7500 + 500;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.05);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Gold")
                {
                    sumOfPrice = 7500 + 750;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.10);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                else if (package == "Platinum")
                {
                    sumOfPrice = 7500 + 1000;
                    sumOfPrice = sumOfPrice - (sumOfPrice * 0.15);
                    Console.WriteLine($"The price per person is {(sumOfPrice / groupSize):F2}$");
                }
                
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }










        }
    }
}
