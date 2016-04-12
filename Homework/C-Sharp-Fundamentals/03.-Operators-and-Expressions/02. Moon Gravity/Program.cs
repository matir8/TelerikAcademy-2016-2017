using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight = float.Parse(Console.ReadLine());
            float weightOnMoon = 0.17f * weight;

            Console.WriteLine("{0:F3}", weightOnMoon);

        }
    }
}
