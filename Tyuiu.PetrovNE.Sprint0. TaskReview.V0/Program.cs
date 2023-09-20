using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PetrovNE.Sprint0.TaskReview.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"({x} + {y} + {z}) * 5 = {DataService.Calc(x, y, z)}");
            Console.ReadKey();
           

        }
    }
}
