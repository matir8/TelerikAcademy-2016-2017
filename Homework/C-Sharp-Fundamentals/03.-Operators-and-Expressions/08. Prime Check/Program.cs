using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("false");
                return;
            }
            else
            {
                for (int i = 2; i < n ; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
            
        }
    }
}
