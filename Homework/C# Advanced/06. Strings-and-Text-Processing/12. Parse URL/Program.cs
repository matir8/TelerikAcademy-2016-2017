using System;

namespace _12.Parse_URL
{   
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string firstSeperator = "://";
            int firstIndex = url.IndexOf(firstSeperator);
            string protocol = url.Substring(0, firstIndex);

            string secondSeperator = "/";
            int secondIndex = url.IndexOf(secondSeperator, firstIndex + firstSeperator.Length);
            string resource = url.Substring(secondIndex);

            string server = url.Substring(firstIndex + 3 , url.Length - (firstIndex + 3 + resource.Length));
            
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
