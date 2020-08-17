using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int br = r * c;
            double sum = 0;
            if(t=="Premiere")
            {
                sum = br * 12.00;
            }
            else if(t=="Normal")
            {
                sum = br * 7.50;
            }
            else if(t=="Discount")
            {
                sum = br * 5.00;
            }
            Console.WriteLine($"{sum:f2} leva");
            
            
        }
    }
}
