using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i <= k - 1; i++)
            {
                long maskP = 1 << p + i;
                long valuesP = (n & maskP) >> (p + i);
                long maskQ = 1 << q + i;
                long valuesQ = (n & maskQ) >> (q + i);
                // checking if value is 0 or 1 and doing the exchange
                if (valuesP == 1)
                {
                    n = n | maskQ;
                }
                else if (valuesP == 0)
                {
                    n = n & ~maskQ;
                }
                if (valuesQ == 1)
                {
                    n = n | maskP;
                }
                else if (valuesQ == 0)
                {
                    n = n & ~maskP;
                }
            }
            Console.WriteLine(n);

        }

    }
}
