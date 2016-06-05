using System;

namespace _08.Binary_short
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = short.Parse(Console.ReadLine());
            string result = Convert.ToString(num, 2).PadLeft(16, '0');
            Console.WriteLine(result);
        }
    }
}
