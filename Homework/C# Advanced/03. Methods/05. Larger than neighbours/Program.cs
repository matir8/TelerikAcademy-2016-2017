﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split(' ');
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            int result = LargerThanN(numbers);
            Console.WriteLine(result);
        }

        static int LargerThanN(int[] numbers)
        {
            int count = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i+1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
