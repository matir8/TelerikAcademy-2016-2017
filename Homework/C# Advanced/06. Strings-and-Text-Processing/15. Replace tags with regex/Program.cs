using System;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
        Regex regex = new Regex(pattern);
        string replacement = "[$2]($1)";
        string result = Regex.Replace(input, pattern, replacement);

        result = result.Replace("(\"", "(");
        result = result.Replace("\")", ")");
        Console.WriteLine(result);
    }
}