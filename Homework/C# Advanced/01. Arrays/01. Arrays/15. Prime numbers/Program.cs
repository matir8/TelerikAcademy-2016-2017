using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long n = long.Parse(Console.ReadLine());
            long a = n;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    a = a/i;
                }   
            }
            if (a == n)
            {
                Console.WriteLine(n);
                return;
            }
            bool[] arr = new bool[n];
            for (int i = 2; i < n; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (arr[i])
                {
                    for (long j = 2; i*j < n; j++)
                    {
                        arr[i * j] = false;
                    }
                }
            }
            for (long i = n - 1; i > 2; i--)
            {
                if (arr[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
