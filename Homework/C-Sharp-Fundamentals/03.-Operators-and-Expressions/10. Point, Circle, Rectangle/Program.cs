using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            
            bool isInCircle = Math.Pow(x - 1, 2.0) + Math.Pow(y - 1, 2.0) <= Math.Pow(1.5, 2);
            bool isInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);

            string answer;
            if (isInCircle)
            {
                 answer = "inside circle";
            }
            else
            {
                answer = "outside circle";
            }
            if (isInRectangle)
            {
                answer = answer + " inside rectangle";
            }
            else
            {
                answer = answer + " outside rectangle";
            }

            Console.WriteLine(answer);
        }
    }
}
