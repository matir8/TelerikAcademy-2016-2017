using System;

namespace _01.Square_root
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double number = double.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                if (double.IsNaN(squareRoot))
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", squareRoot);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
