using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int searched = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            searched = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int firstIndex = 0;
            int lastIndex = arr.Length - 1;
            int middle = (firstIndex + lastIndex) / 2;

            int result = -1;
            while (firstIndex <= lastIndex)
            {
                if (searched > arr[middle])
                {
                    firstIndex = middle + 1;
                }
                else if(searched < arr[middle])
                {
                    lastIndex = middle - 1;
                }
                else
                {
                    result = middle;
                    break;
                }
                middle = (firstIndex + lastIndex)/2;
            }

            Console.WriteLine(result);
        }
    }
}
