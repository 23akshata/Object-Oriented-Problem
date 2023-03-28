using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class DuplicateNumbers
    {
        public static void CheckDuplicate()
        {
            int[] array = { 1, 2, 3, 4, 2, 3 };
            foreach (int num in array)
            {

                Console.WriteLine(num);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        Console.WriteLine("Duplicates numbers is :" + array[i]);

                    }
                }

            }
        }
    }
}
