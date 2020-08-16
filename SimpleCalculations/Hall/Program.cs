using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zala
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double s = (l *100) *w*100 - a * a*100*100 - (l * 100) * w * 100/10;
            double p = s / 7040;
            double down = Math.Floor(p);
            Console.WriteLine(down);

        }
    }
}
