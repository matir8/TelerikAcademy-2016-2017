using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int balance = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    balance++;
                else if (input[i] == ')')
                    balance--;
                if (balance < 0)
                {
                    Console.WriteLine("Incorrect");
                    return;
                }
            }
            if (balance > 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
