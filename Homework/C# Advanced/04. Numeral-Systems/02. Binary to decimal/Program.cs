using System;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            long number = Convert.ToInt64(binary, 2);
            Console.WriteLine(number);
        }
    }
}
