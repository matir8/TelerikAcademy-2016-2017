using System;
using System.Numerics;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');
            int[] numArray = new int[n];
            BigInteger oddProduct = 1;
            BigInteger evenProduct = 1;
            for (int i = 0; i < n; i++)
            {
                numArray[i] = Convert.ToInt32(numbers[i]);
                if (i%2 != 0) oddProduct *= numArray[i];
                else evenProduct *= numArray[i];
            }
            if(oddProduct == evenProduct)
                Console.WriteLine("yes {0}", oddProduct);
            else
                Console.WriteLine("no {0} {1}", evenProduct, oddProduct);

        }
    }
}
