using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
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

            int currNumReps = 1;
            int maxNumReps = 1;
            int maxRepeatedNum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        currNumReps++;
                    }
                    if (j == n - 1)
                    {
                        if (currNumReps > maxNumReps)
                        {
                            maxNumReps = currNumReps;
                            maxRepeatedNum = arr[i];
                        }
                        currNumReps = 1;
                    }
                }
            }

            Console.WriteLine("{0} ({1} times)", maxRepeatedNum, maxNumReps);
        }
    }
}
