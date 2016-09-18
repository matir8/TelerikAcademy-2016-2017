using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0 && n % 7 == 0)
            {
                Console.WriteLine("true {0}", n);
            }
            else
            {
                Console.WriteLine("false {0}", n);
            }
        }
    }
}
