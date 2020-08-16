using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = double.Parse(Console.ReadLine());
            double biral = double.Parse(Console.ReadLine());
            double vinol = double.Parse(Console.ReadLine());
            double rakiql = double.Parse(Console.ReadLine());
            double uiskil = double.Parse(Console.ReadLine());
            double rakiq = (cena / 2 );
           double vino = (rakiq - 0.4 * rakiq)*vinol;
           double bira =( rakiq - 0.8 * rakiq)*biral;
            cena = cena * uiskil;
            double sum = cena + rakiq*rakiql + vino + bira;
            Console.WriteLine("{0:F2}", sum);

        }
    }
}
