using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            var input = Console.ReadLine().Split(' ');
            int searched = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            int result = AppCount(numbers, searched);
            Console.WriteLine(result);
        }

        static int AppCount(int[] numbers, int searched)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searched)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
