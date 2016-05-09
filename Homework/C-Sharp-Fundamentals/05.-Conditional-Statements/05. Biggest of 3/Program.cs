using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            for (int i = 0; i < 3; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine(max);
        }
    }
}
