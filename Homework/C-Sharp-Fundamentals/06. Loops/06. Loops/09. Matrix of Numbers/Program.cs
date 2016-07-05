using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count++;
            }
            for (int col = 1; col <= n; col++)
            {
                for (int row = col; row < n + col; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}