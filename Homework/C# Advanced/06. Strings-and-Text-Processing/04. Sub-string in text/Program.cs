using System;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToUpper();
            int count = 0;
            string text = Console.ReadLine().ToUpper();
            int index = text.IndexOf(pattern);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern,index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
