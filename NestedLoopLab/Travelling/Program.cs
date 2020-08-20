using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while(true)
            {
                sum = 0;
                string d = Console.ReadLine();
                if(d=="End")
                {
                    break;
                }
                int s = int.Parse(Console.ReadLine());
                while(true)
                {
                    int x = int.Parse(Console.ReadLine());
                    sum += x;
                    if(sum>=s)
                    {
                        break;
                    }

                }
                Console.WriteLine($"Going to {d}!");
                
                

            }
        }
    }
}
