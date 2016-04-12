using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = b*b - 4*a*c;

            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {
                double x = -b/(2*a);
                Console.WriteLine("{0:F2}", x);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a); 
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
        }
    }
}
