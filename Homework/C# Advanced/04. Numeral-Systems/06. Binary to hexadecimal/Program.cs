    using System;

    namespace _06.Binary_to_Hexadecimal
    {
        class Program
        {
            static void Main(string[] args)
            {
                string bin = Console.ReadLine();
                long dec = Convert.ToInt64(bin, 2);
                string hex = Convert.ToString(dec, 16).ToUpper();
                Console.WriteLine(hex);
            }
        }
    }
