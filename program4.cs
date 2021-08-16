using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks of p c m");
            int p = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int tot;
            double avg;
            string res = string.Empty;
            string grade = string.Empty;
            tot = p + c + m;
            avg = (double)tot/ 3;
            if(c>=35 && p>=35 && m>=35)
            {
                res = "PASS";
                if (tot > 60)
                    grade = "B";
                else if (tot > 90)
                    grade = "S";
                else if (tot > 80)
                    grade = "A";
                else if (tot > 50)
                    grade = "c";
            }
            else
            {
                grade = "NA";
                res = "fail";
            }
            
            Console.WriteLine($"total = {tot}");
            Console.WriteLine($"avg = {avg}, result={res}, grade={grade}");


  
        }
    }
}
