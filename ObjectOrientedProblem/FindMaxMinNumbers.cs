using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class FindMaxMinNumbers
    {
        public static void FindMaximumMinimum()
        {
            int[] Array = { 10, 20, 30, 40, 50 };
            foreach (int num in Array)
            {
                Console.WriteLine(num);
            }
            int Min = Array[0];
            int Max = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] < Min)
                {
                    Min = Array[i];
                }
                if (Array[i] > Max)
                {
                    Max = Array[i];
                }
            }
            Console.WriteLine("Minimum Element is :" + Min);
            Console.WriteLine("Maximum Element is :" + Max);
        }

    }
}
