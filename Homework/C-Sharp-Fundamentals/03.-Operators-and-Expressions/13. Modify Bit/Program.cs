using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Modify_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            ulong mask = 1;
            ulong result = 1;

            if (v == 1)
            {
                mask = mask << p;
                result = n | mask;
            }
            else
            {
                result = (~(mask << p) & n);
            }

            Console.WriteLine(result);
        }
    }
}
