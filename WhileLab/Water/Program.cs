using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int ml = int.Parse(Console.ReadLine());
            int sum = 0;
            int tap = 0;
            while(sum<ml)
            {
                string s = Console.ReadLine();
                if(s=="Easy")
                {
                    sum = sum + 50;
                    tap++;
                }
                else if(s=="Medium")
                {
                    sum = sum + 100;
                    tap++;
                }
                else if(s=="Hard")
                {
                    sum = sum + 200;
                    tap++;
                }
            }
            if(sum==ml)
            {
                Console.WriteLine($"The dispenser has been tapped {tap} times.");
            }
            else
            {
                Console.WriteLine($"{sum-ml}ml has been spilled.");
            }
        }
    }
}
