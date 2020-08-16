using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horeography
{
    class Program
    {
        static void Main(string[] args)
        {
            double step = double.Parse(Console.ReadLine());
            double dancer = double.Parse(Console.ReadLine());
            double day = double.Parse(Console.ReadLine());
            double x= Math.Ceiling(1/day*100); 
            double p1 = x / dancer;
            if(x<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {p1:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {p1:f2}% steps to be learned per day.");
            }
        }
    }
}
