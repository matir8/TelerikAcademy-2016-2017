using System;

namespace _06.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            input = input.Replace("\n", String.Empty);
            input = input.Replace("\\", String.Empty);
            input = input.Replace("\t", String.Empty);
            while (input.Length < 20)
            {
                input = string.Concat(input, "*");
            }
            Console.WriteLine(input);
        }
    }
}
