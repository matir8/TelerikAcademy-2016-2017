using System;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char temp = input[input.Length - 1 - i];
                reversed = reversed + temp;
            }
            Console.WriteLine(reversed);
        }
    }
}
