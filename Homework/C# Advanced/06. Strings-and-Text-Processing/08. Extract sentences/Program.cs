using System;
using System.Linq;
using System.Text;

namespace _08.Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string magicWord = Console.ReadLine();
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            var sentences = text.Split('.');

            for(int i = 0; i < sentences.Length; i++)
            {
                char[] separators = text.Where(x => !char.IsLetter(x) && x != '.').Distinct().ToArray();
                var words = sentences[i].Split(separators);
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].ToLower() == magicWord)
                    { 
                        result.Append(string.Concat(sentences[i], "."));
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
