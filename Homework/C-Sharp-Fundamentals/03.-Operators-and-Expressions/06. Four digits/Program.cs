using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_digits
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += number%10;
                number /= 10;
            }

            int a = (n/1000)%10;
            int b = (n/100)%10;
            int c = (n/10)%10;
            int d = n%10;

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
