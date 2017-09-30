using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
 
             int counter = 0;
             int combination = 0;
  
             for (int i = n; i <= m; i++)
             {
                 for (int j = n; j <= m; j++)
                 {
                     if (j+i==magic)
                     {
                         Console.WriteLine($"Number found! {j} + {i} = {magic}");
                         combination++;break;
                     }
                     counter++;
                }
                if (combination>0)
                 {
                     break;
                 }
             }
             if (combination==0)
             {
                 Console.WriteLine($"{counter} combinations - neither equals {magic}");
             }
        }
    }
}
