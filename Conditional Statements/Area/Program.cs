using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            if(f=="square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if(f=="rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(x * y);

            }
            else if(f=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(r * r * Math.PI);


            }
            else if(f=="triangle")
            {
                double d = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(d * h / 2);

            }
        }
    }
}
