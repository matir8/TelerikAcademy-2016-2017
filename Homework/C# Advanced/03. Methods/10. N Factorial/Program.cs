﻿using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        static BigInteger Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
