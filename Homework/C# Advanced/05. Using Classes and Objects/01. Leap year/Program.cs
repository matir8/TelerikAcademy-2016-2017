using System;

namespace _01.Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(n) ? "Leap" : "Common");
        }
    }
}
