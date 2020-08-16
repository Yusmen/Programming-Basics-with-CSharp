using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trima_bratq
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double time = 1 / (1 / a + 1 / b + 1 / c);
            time =time +time * 0.15;
            double q = d - time;
            if (q > 0)
            {
                Console.WriteLine($"Cleaning time: {time:f2}");
                double down = Math.Floor(q);
                Console.WriteLine($"Yes, there is a surprise - time left -> {down} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {time:f2}");
                double up = Math.Floor(q);
                Console.WriteLine($"No, there is not a surprise - shortage of time -> {up} hours.");


            }
        }
    }
}
