using System;

namespace _08.Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            Console.WriteLine(Add(numbers));
        }

        static int Add(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }

}
