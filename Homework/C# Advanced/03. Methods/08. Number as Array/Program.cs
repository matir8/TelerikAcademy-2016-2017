using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int firstLength = int.Parse(line[0]);
            int secondLength = int.Parse(line[1]);
            line = Console.ReadLine().Split(' ');
            int[] firstNumber = new int[firstLength];
            int[] secondNumber = new int[secondLength];
            for (int i = 0; i < firstLength; i++)
            {
                firstNumber[i] = int.Parse(line[i]);
            }
            line = Console.ReadLine().Split(' ');
            for (int i = 0; i < secondLength; i++)
            {
                secondNumber[i] = int.Parse(line[i]);
            }
            int[] result = Adding(firstNumber, secondNumber);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] +  " ");
            }

        }

        static int[] Adding(int[] firstNum, int[] secondNum)
        {
            bool isFirst = firstNum.Length > secondNum.Length;
            int maxLength = Math.Max(firstNum.Length, secondNum.Length);
            int minLength = Math.Min(firstNum.Length, secondNum.Length);
            int[] result = new int[maxLength];
            for (int i = 0; i < minLength; i++)
            {
                if ((firstNum[i] + secondNum[i]) > 10)
                {
                    firstNum[i]++;
                }
                result[i] = (firstNum[i] + secondNum[i])%10;
            }
            for (int i = minLength; i < maxLength; i++)
            {
                if (isFirst)
                {
                    result[i] = firstNum[i];
                }
                else
                {
                    result[i] = secondNum[i];
                }
            }
            return result;
        }
    }
}
