using System;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine().ToLower();
            long dec = Convert.ToInt64(hex, 16);
            Console.WriteLine(dec);
        }
    }
}
