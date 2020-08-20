using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string b = Console.ReadLine();
                if (b == "Facebook") 
                {
                    s = s - 150;
                }
               else if (b == "Instagram") 
                {
                    s = s - 100;
                }
               else if (b == "Reddit") 
                {
                    s = s - 50;
                }

                if(s<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                
            }
            Console.WriteLine(s);
        }
    }
}
