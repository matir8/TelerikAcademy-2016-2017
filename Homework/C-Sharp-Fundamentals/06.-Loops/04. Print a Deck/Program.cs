using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_a_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine().ToUpper();
            int n = 0;
            if (sign == "J") n = 11;
            else if (sign == "Q") n = 12;
            else if (sign == "K") n = 13;
            else if (sign == "A") n = 14;
            else n = Convert.ToInt16(sign);

            for (int i = 2; i <= n; i++)
            {
                if (i <= 10) sign = i.ToString();
                if (i == 11) sign = "J";
                if (i == 12) sign = "Q";
                if (i == 13) sign = "K";
                if(i == 14) sign = "A";
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign);
            }
            
        }
    }
}
