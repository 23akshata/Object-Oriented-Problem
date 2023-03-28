using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class FrequencyOfElements
    {
        public static void FindFrequency()
        {
            int[] array = { 10, 20, 30, 40, 50, 60, 70, 10, 10, 20, 30, 30 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int value in array)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0}={1} times", pair.Key, pair.Value);
            }
        }
    }
}
