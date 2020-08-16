using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokrivka
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double pokrivka = ( length + 2* 0.30) * ( width + 2 * 0.30);
            pokrivka = pokrivka * 7*br;
            double kare = (length / 2) * (length / 2);
            kare = kare * 9 * br;
            double sum = pokrivka + kare;
            Console.Write("{0:F2}",sum);
            Console.WriteLine(" USD");
            Console.Write("{0:F2}", sum * 1.85);
            Console.WriteLine(" BGN");


        }
    }
}
