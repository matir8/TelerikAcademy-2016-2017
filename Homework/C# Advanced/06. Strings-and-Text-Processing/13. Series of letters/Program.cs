using System;

namespace _13.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = String.Empty;
            int length = input.Length;
            char last = new char();
            foreach (char current in input)
            {
                if (current != last)
                {
                    result = String.Concat(result, current);
                }
                last = current;
            }
            Console.WriteLine(result);
        }
    }
}
