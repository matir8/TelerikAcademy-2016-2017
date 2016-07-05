using System;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        public static BigInteger Factorial(uint i)
        {
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            BigInteger result = Factorial(n)/Factorial(k);
            Console.WriteLine(result);
        }
    }
}
