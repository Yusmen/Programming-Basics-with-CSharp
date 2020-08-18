using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double comission = -1.0;
            if(town=="sofia")
            {
                if(s>=0&&s<=500)
                {
                    comission = 0.05;
                }
                else if(s>500&&s<=1000)
                {
                    comission = 0.07;
                }
                else if(s>1000&&s<=10000)
                {
                    comission = 0.08;
                }
                else if(s>10000)
                {
                    comission = 0.12;
                }
            }
            else if(town=="varna")
            {
                if (s >= 0 && s <= 500)
                {
                    comission = 0.045;
                }
                else if (s > 500 && s <= 1000)
                {
                    comission = 0.075;
                }
                else if (s > 1000 && s <= 10000)
                {
                    comission = 0.1;
                }
                else if (s > 10000)
                {
                    comission = 0.13;
                }
            }
            else if(town=="plovdiv")
            {
                if (s >= 0 && s <= 500)
                {
                    comission = 0.055;
                }
                else if (s > 500 && s <= 1000)
                {
                    comission = 0.08;
                }
                else if (s > 1000 && s <= 10000)
                {
                    comission = 0.12;
                }
                else if (s > 10000)
                {
                    comission = 0.145;
                }
            }
            if(comission>=0)
            {
                Console.WriteLine("{0:f2}",comission * s);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
