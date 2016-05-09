using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int currSum = arr[0];
            int maxSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currSum = Math.Max(arr[i], currSum + arr[i]);
                maxSum = Math.Max(currSum, maxSum);
            }

            Console.WriteLine(maxSum);

        }
    }
}
