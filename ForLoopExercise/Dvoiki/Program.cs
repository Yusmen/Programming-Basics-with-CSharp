using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvoiki
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = 0;
            int sum = 0;
            int m = 0;
            int d =0;

            for (int i = 1; i <= n; i++) 
            {
                sum = m;
               int num1 = int.Parse(Console.ReadLine());
               int num2 = int.Parse(Console.ReadLine());

                m = num1 + num2;
                d = Math.Abs(m - sum);

                if (sum != m && i >= 2) 
                {
                    max = m;
                }
                if (d > max && i >= 2) 
                {
                    max = d;
                }
            }
           
           if(max!=0)
            {
                Console.WriteLine($"No, maxdiff={max}");
            }
            else
            {
                Console.WriteLine($"Yes, value={m}");
            }
        }
    }
}
