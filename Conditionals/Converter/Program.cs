using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if(a=="mm")
            {
                x = x / 1000;
            }
            else if(a=="cm")
            {
                x = x / 100;
            }
            else if(a=="mi")
            {
                x = x / 0.000621371192;
            }
            else if(a=="in")
            {
                x = x / 39.3700787;
            }
            else if(a=="km")
            {
                x = x / 0.001;
            }
            else if(a=="ft")
            {
                x = x / 3.2808399;
            }
            else if(a=="yd")
            {
                x = x / 1.0936133;
            }
            double r = 0;
            if (b == "m") 
            {
                r = x;
            }
            else if(b=="mm")
            {
                r = x * 1000;
            }
            else if(b=="cm")
            {
                r = x * 100;
            }
            else if(b=="mi")
            {
                r = x * 0.000621371192;
            }
            else if(b=="in")
            {
                r = x * 39.3700787;
            }
            else if(b=="km")
            {
                r = x * 0.001;
            }
            else if(b=="ft")
            {
                r = x * 3.2808399;
            }
            else if(b=="yd")
            {
                r = x * 1.0936133;
            }
            Console.WriteLine($"{r:f8}");
        }
    }
}
