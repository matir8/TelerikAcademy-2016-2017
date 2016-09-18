using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInCircle = Math.Pow(x - 0, 2.0) + Math.Pow(y - 0, 2.0) < Math.Pow(2,2);
            double distance = Math.Sqrt(Math.Abs(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)));

            if (isInCircle)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}
