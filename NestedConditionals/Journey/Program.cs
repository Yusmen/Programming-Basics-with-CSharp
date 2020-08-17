using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            string s = Console.ReadLine().ToLower();
            if(b<=100)
            {
                if(s=="summer")
                {
                    b = 0.3 * b;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {b:f2}");

                }
                else if(s=="winter")
                {
                    b =  b * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {b:f2}");
                       
                }
                
            }
            else if(b>100&&b<=1000)
            {
                if(s=="summer")
                {
                  b =  b * 0.40;
                  Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {b:f2}");
                }
                else if(s=="winter")
                {
                    b = b * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {b:f2}");


                }
                

            }
            else if(b>1000)
            {
                b = b * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {b:f2}");
            }
        }
    }
}
