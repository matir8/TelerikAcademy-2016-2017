using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            double n = 0;
            int bit = 0;
            char temp = hex[0];
            for (int i = hex.Length - 1, j = 0; i >= 0; i--, j++)
            {
                temp = hex[i];
                switch (temp)
                {

                    case '0':
                        bit = 0; break;
                    case '1':
                        bit = 1;break;
                    case '2':
                        bit = 2; break;
                    case '3':
                        bit = 3; break;
                    case '4':
                        bit = 4; break;
                    case '5':
                        bit = 5; break;
                    case '6':
                        bit = 6; break;
                    case '7':
                        bit = 7; break;
                    case '8':
                        bit = 8; break;
                    case '9':
                        bit = 9; break;
                    case 'A':
                        bit = 10; break;
                    case 'B':
                        bit = 11; break;
                    case 'C':
                        bit = 12; break;
                    case 'D':
                        bit = 13; break;
                    case 'E':
                        bit = 14; break;
                    case 'F':
                        bit = 15; break;

                }
                n = n + (bit * Math.Pow(16, j));
            }
            Console.WriteLine(n);
        }
    }
}