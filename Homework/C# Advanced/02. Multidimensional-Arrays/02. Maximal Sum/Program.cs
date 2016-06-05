using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var split = line.Split(' ');
            int rows = Convert.ToInt32(split[0]);
            int cols = Convert.ToInt32(split[1]);

            int[,] matrix = new int[rows,cols];

            int currSum = Int32.MinValue;
            int maxSum = Int32.MinValue;

            for (int row = 0; row < rows; row++)
            {
                line = Console.ReadLine();
                split = line.Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(split[col]);
                }
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    maxSum = Math.Max(currSum, maxSum);
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
