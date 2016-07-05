using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
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
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while (n != 0)
            {
                int bit = n%2;
                binary = binary + bit;
                n /= 2;
            }
            binary = Reverse(binary);
            Console.WriteLine(binary);
        }
    }
}
