using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r = 0;
            if (b == 0)
            {
                r = a;
            }
            else
            {
                while (b != 0)
                {
                    r = b;
                    b = a % b;
                    a = r;
                }

                        
            }
            Console.WriteLine(r);
         
        }
    }
}
