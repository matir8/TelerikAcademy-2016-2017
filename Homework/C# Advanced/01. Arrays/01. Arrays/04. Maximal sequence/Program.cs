using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int currNum = 0;
            int lastNum = currNum;
            int count = 1;
            int maxCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                currNum = arr[i];
                if (currNum == lastNum)
                {
                    count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
                if (currNum != lastNum)
                {
                    count = 1;
                }
                lastNum = currNum;
            }
            Console.WriteLine(maxCount);
        }
    }
}
