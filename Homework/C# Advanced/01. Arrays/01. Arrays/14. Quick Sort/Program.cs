using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_Sort
{
    class Program
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot);
                QuickSort(arr, pivot + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int leftWall = low;

            for (int i = low + 1; i < high; i++)
            {
                if (arr[i] < pivot)
                {
                    leftWall = leftWall + 1;
                    int temp = arr[i];
                    arr[i] = arr[leftWall];
                    arr[leftWall] = temp;
                }
            }
            int tmp = arr[low];
            arr[low] = arr[leftWall];
            arr[leftWall] = tmp;

            return leftWall;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            QuickSort(numbers, 0, n);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
