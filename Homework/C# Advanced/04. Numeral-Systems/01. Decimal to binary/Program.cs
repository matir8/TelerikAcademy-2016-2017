using System;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(binary);
        }
    }
}
