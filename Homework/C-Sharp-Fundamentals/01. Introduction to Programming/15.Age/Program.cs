using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            char delimiter = '.';
            String[] subStrings = date.Split(delimiter);
            int month = int.Parse(subStrings[0]);
            int day = int.Parse(subStrings[1]);
            int year = int.Parse(subStrings[2]);

            DateTime birthday = new DateTime(year, month, day);
            DateTime today = DateTime.Now;

            Console.WriteLine(Math.Truncate(((today - birthday).TotalDays)/365.0));
            Console.WriteLine(10 + (Math.Truncate(((today - birthday).TotalDays) / 365.0)));
        }
    }
}
