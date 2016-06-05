using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            var line = Console.ReadLine().Split(' ');
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        static int[] Sort(int[] numbers)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }
            
            return numbers;
        }
    }
}
