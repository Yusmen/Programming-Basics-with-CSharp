using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladki
{
    class Program
    {
        static void Main(string[] args)
        {
            double dni = double.Parse(Console.ReadLine());
            double sladkari = double.Parse(Console.ReadLine());
            double torti = double.Parse(Console.ReadLine());
            double gof = double.Parse(Console.ReadLine());
            double pal = double.Parse(Console.ReadLine());
            torti = torti * 45;
            gof = gof * 5.80;
            pal = pal * 3.20;
            double sum = (torti + gof + pal) *dni*sladkari;
            sum = sum - 0.125* sum;
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
