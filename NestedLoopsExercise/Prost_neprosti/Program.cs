using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prost_neprosti
{
    class Program
    {
        static void Main(string[] args)
        {
            int pr = 0;
            int nepr = 0;
            int flag = 0;
            while(true)
            {
                
                string s = Console.ReadLine();
                if(s=="stop")
                {
                    break;
                }
                int num = int.Parse(s);
                if(num<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = 1;
                            nepr += num;
                            break;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                    if (flag == 0)
                    {
                        pr += num;
                    }
                }
               
            }
            Console.WriteLine($"Sum of all prime numbers is: {pr}");
            Console.WriteLine($"Sum of all non prime numbers is: {nepr}");
        }
    }
}
