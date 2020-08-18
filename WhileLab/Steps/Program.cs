using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            while(s!="Going home")
            {
                int a = Convert.ToInt32(s);
                sum = sum + a;
                if(sum>=10000)
                {
                    Console.WriteLine("Goal reached! Good job!");break;
                }
                s = Console.ReadLine();
               
                
                
                
            }
            if(s=="Going home")
            {
             s = Console.ReadLine();
             int b = Convert.ToInt32(s);
             sum = sum + b;
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");
                }

            }

           

        }
    }
}
