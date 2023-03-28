using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Object Oriented Practice Problems");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Duplicate Element \n2.Unique Element\n3Frequency Of Element\n4 Find Max & Min\n5.Create Reverse Right Star Pattern ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Duplicate Number");
                    DuplicateNumbers.CheckDuplicate();
                    break;

                case 2:
                    UniqueElements.CheckUniqueElement();
                    break;

                case 3:
                    FrequencyOfElements.FindFrequency();
                    break;

                case 4:
                    FindMaxMinNumbers.FindMaximumMinimum();
                    break;

                case 5:
                    ReversePattern.CreateReverseRightStarPattern();
                    break;

                case 6:
                    RectagularPattern.CreateRectanglaStarPattern();
                    break;

                case 7:
                    ReverseString.ReverseWord();
                    break;

                case 8:
                    SumOfAllDigit.CalculateSum();
                    break;

                case 9:
                    SumOfMatrix.SumMatrix();
                    break;

            }
        }
    }
}
