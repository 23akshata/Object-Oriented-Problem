using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class ReverseString
    {
        public static void ReverseWord()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();
            Console.WriteLine(word);
            string result = "";
            char[] Array = word.ToCharArray();
            for (int i = Array.Length - 1; i >= 0; i--)
            {
                result += Array[i];
            }
            Console.WriteLine(result);

        }
    }
}
