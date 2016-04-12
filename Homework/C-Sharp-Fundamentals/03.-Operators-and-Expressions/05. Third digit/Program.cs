using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ((n/100) % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                int thirdDigit = (n/100) % 10;
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
