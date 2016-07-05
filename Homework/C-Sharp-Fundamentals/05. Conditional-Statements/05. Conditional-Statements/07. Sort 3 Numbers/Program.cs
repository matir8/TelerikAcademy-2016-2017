using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            for (int i = 0; i < 3; i++)
            {
                if (a < b)
                {
                    d = a;
                    a = b;
                    b = d;
                }
                if (b < c)
                {
                    d = b;
                    b = c;
                    c = d;
                }
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
