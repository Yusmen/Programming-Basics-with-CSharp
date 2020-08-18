using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            
            if(n>=1&&n<=4)
            {
                b = b - b * 0.75;
            }
            else if(n>=5&&n<=9)
            {
                b = b - b * 0.60;
            }
            else if(n>=10&&n<=24)
            {
                b = b - b * 0.50;
            }
            else if(n>=25&&n<=49)
            {
                b = b - b * 0.40;
            }
            else if(n>=50)
            {
                b = b - b * 0.25;
            }
            if(category=="VIP")
            {
                b=b - n * 499.99;
            }
            else
            {
                if(category=="Normal")
                {
                    b = b - n * 249.99;
                }
            }
            if(b>=0)
            {
                Console.WriteLine($"Yes! You have {b:f2} leva left.");
            }
            else
            {
                b = b - 2 * b;
                Console.WriteLine($"Not enough money! You need {b:f2} leva.");
            }
        }
    }
}
