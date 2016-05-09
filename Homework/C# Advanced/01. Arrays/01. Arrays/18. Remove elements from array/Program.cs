using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        public static int LIS(int[] input)
        {
            {
                int[] longest = new int[input.Length];
                int result = 1;
                for (int i = 0; i < input.Length; ++i)
                {
                    longest[i] = 1;
                    for (int j = 0; j < i; ++j)
                    {
                        if (input[j] < input[i] && longest[j] + 1 > longest[i])
                            longest[i] = longest[j] + 1;
                        if (longest[j] > result) result = longest[i];
                    }

                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int minNumsToRemove = numbers.Length - LIS(numbers);

            Console.WriteLine(minNumsToRemove);
        }
    }
}
