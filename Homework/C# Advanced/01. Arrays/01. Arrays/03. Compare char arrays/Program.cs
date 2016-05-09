using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();


            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    return;
                }
                else
                {
                    if (first.Length > second.Length)
                    {
                        Console.WriteLine(">");
                        return;
                    }
                    else if (first.Length < second.Length)
                    {
                        Console.WriteLine("<");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("=");
                        return;
                    }
                }

            }

            


        }
    }
}
