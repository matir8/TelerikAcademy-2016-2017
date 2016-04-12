using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong first = 0;
            ulong second = 1;
            ulong current = 0;

            if (n == 1)
            {
                Console.Write(first);
            }
            else if (n == 2)
            {
                Console.Write(first + ", " + second);
            }
            else
            {
                Console.Write(first + ", " + second);
                for (int i = 1; i < n - 1; i++)
                {
                    current = first + second;
                    Console.Write(", " + current);
                    first = second;
                    second = current;
                }
            }
        }
    }
}
