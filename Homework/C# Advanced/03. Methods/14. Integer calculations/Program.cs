using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            double[] numbers = new double[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = double.Parse(line[i]);
            }
            Console.WriteLine(Min(numbers));
            Console.WriteLine(Max(numbers));
            Console.WriteLine("{0:F2}", Average(numbers));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));
        }

        static double Min(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static double Max(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static double Average(double[] numbers)
        {
            double avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }
            avg = avg/numbers.Length;
            return avg;
        }

        static double Sum(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static long Product(double[] numbers)
        {
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= Convert.ToInt64(numbers[i]);
            }
            return product;
        }
    }
}
