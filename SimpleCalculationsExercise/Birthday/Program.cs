using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double obem = l * d * h;
            double litri = obem * 0.001;
            p = p * 0.01;
            litri = litri * (1 - p);
            Console.WriteLine("{0:F3}",litri);

        }
    }
}
