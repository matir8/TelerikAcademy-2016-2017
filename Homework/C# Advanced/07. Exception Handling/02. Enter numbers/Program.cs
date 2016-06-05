using System;
namespace _02.Enter_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadNumber(1, 100);
        }

        static void ReadNumber(int start, int end)
        {
            try
            {
                int[] numbers = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1] || numbers[i] < start || numbers[i] > end)
                        throw new Exception("Exception");
                        

                }
                string result = String.Empty;
                foreach (var num in numbers)
                {
                    result = result + " < " + num;
                }
                result = result.Insert(0, start.ToString());
                result = result + " < " + end;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            
        }
    }
}
