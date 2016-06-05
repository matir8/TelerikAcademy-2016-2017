using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static int GetLargest(SortedSet<int> numbers)
        {
            return numbers.Max;
        }
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach (var num in input)
            {
                numbers.Add(Convert.ToInt32(num));
            }
            Console.WriteLine(GetLargest(numbers));
        }
    }
}
