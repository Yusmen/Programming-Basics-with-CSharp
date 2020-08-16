using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            x = x * 1.79549;
            Console.Write("{0:F2}",x);
            Console.Write("  BGN");
        }
    }
}
