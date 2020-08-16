using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m + 15 > 59 && h == 23)
            {
                if (m + 15 - 60 < 10)
                {
                    Console.WriteLine("0:0{0}", m + 15 - 60);
                }
                else
                {
                    Console.WriteLine("0:{0}", m + 15 - 60);
                }
            }
            else
            {
                if (m + 15 > 59)
                {
                    if (m + 15 - 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1}", h + 1, m + 15 - 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", h + 1, m + 15 - 60);
                    }
                }
                else
                {
                    Console.WriteLine("{0}:{1}", h, m + 15);
                }
            }

        }
    }
}      
