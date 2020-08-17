using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double total = (48 - h) * 3.0 / 4 + h + p * 2.0 / 3;
            if(y=="leap")
            {
                total = total+total*0.15;
               double down= Math.Truncate(total);
                Console.WriteLine(down);
            }
            else if(y=="normal")
            {
                
                double down=Math.Truncate(total);
                Console.WriteLine(down);
            }


        }
    }
}
