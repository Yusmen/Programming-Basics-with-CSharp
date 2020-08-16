using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_points
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double br = 0;
            if(x<=100)
            {
                br = br + 5;
            }
            else if(x>100&&x<1000)
            { 
                br = br + x *0.2;
            }
            else if(x>=1000)
            {
                
                br = br + x * 0.1;
            }
            if(x%2==0)
            {
                br++;
            }
            else if(x%10==5)
            {
                
                    br+=2;
                
            }
            Console.WriteLine(br);
            Console.WriteLine(x+br);
        }
    }
}
