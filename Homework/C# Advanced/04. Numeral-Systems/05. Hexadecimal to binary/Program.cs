using System;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine().ToLower();
            long dec = Convert.ToInt64(hex, 16);
            string bin = Convert.ToString(dec, 2);
            Console.WriteLine(bin);
        }
    }
}
