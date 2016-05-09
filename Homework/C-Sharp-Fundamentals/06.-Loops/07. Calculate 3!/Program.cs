using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        public static BigInteger Factorial(int i)
        {
            if(i <= 1) return 1;
            return i * Factorial(i - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            sum = Factorial(n) / (Factorial(k) * Factorial(n - k));
            Console.WriteLine(sum);
        }
    }
}
