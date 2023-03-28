using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class RectagularPattern
    {
        public static void CreateRectanglaStarPattern()
        {
            Console.WriteLine("Enter Length of rectangle ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");

            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= l; j++)
                {
                    if (i == 1 || i == b || j == 1 || j == l)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n ");
            }
        }
    }
}
