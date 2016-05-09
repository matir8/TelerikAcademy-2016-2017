using System;
using System.Numerics;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool areEqual = false;
            BigInteger[] first = new BigInteger[n];
            BigInteger[] second = new BigInteger[n];
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = BigInteger.Parse(Console.ReadLine());
            }
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = BigInteger.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (first[i] == second[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine(areEqual ? "Equal" : "Not equal");
        }
    }
}
