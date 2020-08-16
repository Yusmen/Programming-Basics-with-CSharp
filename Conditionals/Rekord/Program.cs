using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double x = length * time;
            double z=Math.Floor(length / 15) * 12.5;
            double total = x + z;
            if (total < record)
            {
                Console.WriteLine(" Yes, he succeeded! The new world record is {0:f2} seconds.", total);
            }
            else
            {
                double a= total-record;
                Math.Abs(a);
                Console.WriteLine($"No, he failed! He was {a:f2} seconds slower.");
            }
        }
    }
}
