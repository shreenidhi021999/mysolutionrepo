using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hiii enter name");
            string name = Console.ReadLine();
            string first = name.Substring(0, name.IndexOf(" "));
            string last = name.Substring( name.LastIndexOf(" "));
            Console.WriteLine($"name= {name} first name= {first} lastname={last}");
        }
    }
}
