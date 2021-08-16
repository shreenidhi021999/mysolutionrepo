using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program6
    {
        static void Main(string[] args)
        {
            var v1 = 100;
            Console.WriteLine($"var {v1} is of type  { v1.GetType()}");
            var v2 = 100.23;
            Console.WriteLine($"var {v2} is of type  {v2.GetType()}");
            var v3 = 's';
            Console.WriteLine($"var {v3} is of type  {v3.GetType()}");
            var v4 = "shree";
            Console.WriteLine($"var {v4} is of type  {v4.GetType()}");
        }
    }
}
