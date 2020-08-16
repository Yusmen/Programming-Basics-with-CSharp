
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskurziq
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = double.Parse(Console.ReadLine());
            int pazel = int.Parse(Console.ReadLine());
            int kukla = int.Parse(Console.ReadLine());
            int meche = int.Parse(Console.ReadLine());
            int minon = int.Parse(Console.ReadLine());
            int kamion = int.Parse(Console.ReadLine());
            double x = pazel * 2.60 + kukla * 3 + meche * 4.10 + minon * 8.20 + kamion * 2;
            double b = pazel + kukla + meche + minon + kamion;
 
            if (b >= 50)
            {
                x = x * 0.75;
            }

            x = x * 0.9;


            if (x >= cena)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", x - cena);
            }
            else
            {
               Console.WriteLine("Not enough money! {0:F2} lv needed.", cena - x);
            }


        }
    }  }
