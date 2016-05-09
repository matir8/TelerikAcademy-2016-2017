using System;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Program
    {
        public static BigInteger Factorial(int i)
        {
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum;
            sum = Factorial(2*n)/(Factorial(n + 1)*Factorial(n));
            Console.WriteLine(sum);
        }
    }
}
