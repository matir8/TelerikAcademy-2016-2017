using System;

namespace _10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char character in input)
            {
                Console.Write("\\u{0:X4}", (int)character);
            }
        }
    }
}