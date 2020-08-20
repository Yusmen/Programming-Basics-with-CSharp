using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = double.Parse(Console.ReadLine());
            double f = g * 1.8 + 32;
            Math.Round(f, 2);
            Console.WriteLine(f);

        }
    }
}
