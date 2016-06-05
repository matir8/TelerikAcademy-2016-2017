using System;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            string result = Reverse(number);
            Console.WriteLine(result);
        }

        static string Reverse(string number)
        {
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed = reversed + number[i];
            }
            return reversed;
        }
    }
}
