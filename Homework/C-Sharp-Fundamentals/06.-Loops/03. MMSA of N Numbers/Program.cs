using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double avg = 0.0;
            double min = double.MinValue;
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double j = double.Parse(Console.ReadLine());
                if (i == 0) min = j;
                if (j > max) max = j;
                if (j < min) min = j;
                sum += j;
                avg = sum / n;
            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
