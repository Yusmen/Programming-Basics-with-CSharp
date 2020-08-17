using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double c1 = 0,c2=0;
            if (m == "May" || m == "October")
            {
                if(n>7&&n<=14)
                {
                    c1 = n * (50-50 * 0.05);
                    c2 = n * 65;
                }
                if(n>14)
                {
                    c1 = n * (50 - 50 * 0.30);
                    c2 = n * (65 - 65 * 0.10);

                }
                
            }
            else if(m=="June"||m=="September")
            {
               
                if (n >14)
                {
                    c1 = n * (75.20 - 75.20 * 0.20);
                    c2 = n * (68.70 - 68.70 * 0.10);

                }
                else
                {
                    c1 = n * 75.20;
                    
                        c2= n * (68.70 - 68.70 * 0.10);
                    
                    
                    
                }

            }
            else if(m=="July"||m=="August")
            {

                c1 = n * 76;
                if(n>14)
                {
                  c2 = n * (77 - 77 * 0.10);
                }
                else
                {
                    c2 = n * 77;
                }
               
            }
          
            Console.WriteLine($"Apartment: {c2:f2} lv.");
  Console.WriteLine($"Studio: {c1:f2} lv.");
                    
        }
    }
}
