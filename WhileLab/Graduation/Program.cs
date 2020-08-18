using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double c = 1;
            double sum = 0;
            while (c <= 12)
            {
                double g = double.Parse(Console.ReadLine());
                if (g >= 4.00)
                {
                    sum = sum + g;
                    c++;
                }
            }
            double average = sum / 12;
            Console.WriteLine($" {name} graduated. Average grade: {average:f2}");
        }
    }
}
