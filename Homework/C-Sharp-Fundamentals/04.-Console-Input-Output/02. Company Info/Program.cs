﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            if (faxNumber == "")
                faxNumber = "(no fax)";

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
        }
    }
}
