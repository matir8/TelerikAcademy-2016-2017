using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint p = uint.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            ulong mask = 1;
            mask = mask << n;
            Console.WriteLine((mask & p) != 0 ? "1" : "0");
        }
    }
}
