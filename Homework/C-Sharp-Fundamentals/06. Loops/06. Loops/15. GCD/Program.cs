using System;

namespace _15.GCD
{
    class Program
    {
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }  
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int a = Convert.ToInt32(numbers[0]);
            int b = Convert.ToInt32(numbers[1]);
            int gcd = GCD(a, b);
            Console.WriteLine(gcd);

        }

    }
}
