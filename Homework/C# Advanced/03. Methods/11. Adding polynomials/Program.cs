using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            var line = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(line[i]);
            }
            line = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(line[i]);
            }
            int[] result = AddPolynomials(a, b);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        static int[] AddPolynomials(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] + b[i];
            }
            return result;
        }
    }
}
