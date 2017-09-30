using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int TotalCalories = 0;


            for (int i = 1; i <= count; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    TotalCalories = TotalCalories + 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    TotalCalories = TotalCalories + 150;
                }
                else if (ingredients == "salami")
                {
                    TotalCalories = TotalCalories + 600;
                }
                else if (ingredients == "pepper")
                {
                    TotalCalories = TotalCalories + 50;
                }
            }
            Console.WriteLine($"Total calories: {TotalCalories}");



        }
    }
}
