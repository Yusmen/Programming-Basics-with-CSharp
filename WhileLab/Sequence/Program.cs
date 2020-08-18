using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redica
{
    class Program
    {
        static void Main(string[] args)
        {   string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            int max = 0;
            int min = a;
            
            while (s!="END")
            {
                a = Convert.ToInt32(s);
                if (a >= max)
                {
                    max = a;
                }

                else if (a <= min)
                {
                    min = a;
                }
                s = Console.ReadLine();
                
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
           
            
        }
    }
}
