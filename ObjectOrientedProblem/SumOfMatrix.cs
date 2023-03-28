using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class SumOfMatrix
    {
        public static void SumMatrix()
        {
            Console.WriteLine("Please Enter Number of Row you want");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number of Collume you want");
            int collume = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[row, collume];
            Console.WriteLine("Please Enter Matrix value one by one");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < collume; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //next for loop for Display Given matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < collume; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Sum of Each digit in Row
            Console.WriteLine("Row sums:");
            for (int i = 0; i < row; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < collume; j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine("Row " + (i + 1) + " sum: " + rowSum);
            }

        }
    }
}
