using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            double n = 0;
            int bit = 0;
            for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (binary[i] == '1')
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }
                n = n + (bit * Math.Pow(2, j));
            }
            Console.WriteLine(n);
        }
    }
}
