using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3rd_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << 3;
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}
