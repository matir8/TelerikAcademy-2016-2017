using System;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeros = 0;
            for (int i = 5; n/i >= 1 ;i*=5)
            {
                zeros += n/i;
            }
            Console.WriteLine(zeros);
        }
    }
}
