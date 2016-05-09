using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letters =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u','v', 'w', 'x', 'y', 'z'
            };
            
            for (int i = 0; i < word.Length; i++)
            {
                int firstIndex = 0;
                int lastIndex = letters.Length - 1;
                int middle = (firstIndex + lastIndex) / 2;
                char letter = word[i];
                while (firstIndex <= lastIndex)
                {
                    if (letter > letters[middle])
                    {
                        firstIndex = middle + 1;
                    }
                    else if (letter < letters[middle])
                    {
                        lastIndex = middle - 1;
                    }
                    else
                    {
                        Console.WriteLine(middle);
                        break;

                    }
                    middle = (firstIndex + lastIndex) / 2;
                }
            }
                
            }
        }
    }
