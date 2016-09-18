using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfMinuses = 0;
            for (int i = 0; i < 3; i++)
            {
                
                double n = double.Parse(Console.ReadLine());
                if (n < 0) numOfMinuses++;
                if (n == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            if(numOfMinuses % 2 == 0) Console.WriteLine("+");
            else Console.WriteLine("-");
        }
    }
}
