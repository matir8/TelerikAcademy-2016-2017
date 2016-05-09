using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "integer")
            {
                int i = int.Parse(Console.ReadLine());
                i++;
                Console.WriteLine(i);
            }
            else if (type == "real")
            {
                double n = double.Parse(Console.ReadLine());
                n++;
                Console.WriteLine("{0:F2}", n);
            }
            else if(type == "text")
            {
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                ;
            }
        }
    }
}
