using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double masterSuitePrice = 0;
            

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * daysCount;
                doublePrice = 65 * daysCount;
                masterSuitePrice = 75 * daysCount;
                if (daysCount > 7)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                    if (month == "October")
                    {
                        studioPrice = studioPrice - 50;
                    }
                }
                
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * daysCount;
                doublePrice = 72 * daysCount;
                masterSuitePrice = 82 * daysCount;

                if (daysCount > 7)
                {
                    if (month == "September")
                    {
                        studioPrice = studioPrice - 60;
                    }
                    if (daysCount > 14)
                    {
                        doublePrice = doublePrice - (doublePrice * 0.10);
                    }


                }
                
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * daysCount;
                doublePrice = 77 * daysCount;
                masterSuitePrice = 89 * daysCount;

                if (daysCount > 14)
                {
                    masterSuitePrice = masterSuitePrice - (masterSuitePrice * 0.15);
                }
                
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");
            }









        }
    }
}
