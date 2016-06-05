using System;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            Console.WriteLine(hex.ToUpper());
        }
    }
}
