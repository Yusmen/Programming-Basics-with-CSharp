using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            if (s < 4.50 || d > m)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (s > 4.5 && s < 5.5 && d < m)
            {
                {
                    Math.Floor(m * 0.35);
                    Console.WriteLine($"You get a Social scholarship {m * 0.35} BGN");
                }

            }
            if (s >= 5.5 && d > m)
            {
                Math.Floor(s * 25);
                Console.WriteLine($"You get a scholarship for excellent results  {s * 25} BGN");
            }
            else if (d < m)
            {
                Math.Floor(m * 0.35);
                Console.WriteLine($"You get a Social scholarship {m * 0.35} BGN");

            }
        }
    }
}
