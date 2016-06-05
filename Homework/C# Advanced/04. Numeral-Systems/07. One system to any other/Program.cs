using System;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            long dec = AnyToDec(number, s);
            string result = DecToAny(dec, d);
            Console.WriteLine(result);
        }
        public static long AnyToDec(string number, int radix)
        {
            const string Digits = "0123456789ABCDEF";

            if (String.IsNullOrEmpty(number))
                return 0;
            
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];

                int digit = Digits.IndexOf(c);
                
                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }
        public static string DecToAny(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEF";
            
            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);

            return result;
        }
    }
}
