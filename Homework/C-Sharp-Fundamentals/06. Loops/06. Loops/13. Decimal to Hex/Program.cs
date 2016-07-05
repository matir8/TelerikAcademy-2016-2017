using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decimal_to_Hex
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string hex = "";
            string bit = "";
            while (n != 0)
            {
                bit = (n % 16).ToString();
                if (bit == "10")
                    bit = "A";
                else if (bit == "11")
                    bit = "B";
                else if (bit == "12")
                    bit = "C";
                else if (bit == "13")
                    bit = "D";
                else if (bit == "14")
                    bit = "E";
                else if (bit == "15")
                    bit = "F";
                hex = hex + bit;
                n /= 16;
            }
            hex = Reverse(hex);
            Console.WriteLine(hex);

        }
    }
}
