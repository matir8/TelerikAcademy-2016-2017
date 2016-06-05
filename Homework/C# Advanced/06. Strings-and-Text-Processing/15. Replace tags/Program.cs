using System;

namespace _15.Replace_tags
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = String.Empty;

            input = input.Replace("<a href=\"", "(");
            input = input.Replace("\">", ")");
            int startIndex = input.IndexOf(")") + 1;
            int lastIndex = input.IndexOf("</a>");
            int length = lastIndex - startIndex;
            string description = string.Concat("[", string.Concat(input.Substring(startIndex, length), "]"));
            string toMove = input.Substring(0, input.IndexOf("a>") + 2);

            while (lastIndex != -1)
            {
                startIndex = input.IndexOf(")") + 1;
                lastIndex = input.IndexOf("</a>");
                length = (lastIndex - startIndex);
                if (length < 0)
                {
                    break;
                }
                description = "[" + input.Substring(startIndex, length) + "]";
                input = input.Remove(startIndex, length);
                input = input.Insert(input.IndexOf("("), description);
                toMove = input.Substring(0, input.IndexOf("a>") + 2);
                result = string.Concat(result, toMove);
                input = input.Remove(0, toMove.Length);
            }


            result = string.Concat(result, input);
            result = result.Replace("</a>", string.Empty);
            

            Console.WriteLine(result);
        }
    }
}
