using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string openingTag = "<upcase>";
            string closingTag = "</upcase>";

            int startIndex = text.IndexOf(openingTag);
            int finishIndex = text.IndexOf(closingTag);

            while (startIndex != -1)
            { 
                string temp = text.Substring(startIndex + openingTag.Length, finishIndex - startIndex - openingTag.Length).ToUpper();
                text = text.Remove(startIndex, openingTag.Length + (finishIndex - startIndex) + 1);
                text = text.Insert(startIndex, temp);

                startIndex = text.IndexOf(openingTag);
                finishIndex = text.IndexOf(closingTag);
            }
            
            Console.WriteLine(text);
        }
    }
}
