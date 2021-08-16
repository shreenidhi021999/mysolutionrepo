using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the lmr pmr");
            int lmr = Convert.ToInt32(Console.ReadLine());
            int pmr = Convert.ToInt32(Console.ReadLine());
            double res;
            int bu = pmr - lmr;
            if (bu < 150)
                res = 1.75 * bu;
            else if (bu < 375)
                res = 1.75 * 150 + (bu - 150) * 3.25;
            else if (bu < 500)
                res = 1.75 * 150 + 225 * 3.25+ (bu-500)*5;
            else if (bu < 375)
                res = 1.75 * 150 + (bu - 150) * 3.25;


        }
    }
}
