using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            x *= 100;
            int a = 0;
          
            while(x>=200)
            {
                x = x - 200;
                a++;
            }
            while (x >= 100)
            {
                x = x - 100;
                a++;
            }
            while (x >= 50)
            {
                x = x - 50;
                a++;
            }
            while (x >= 20)
            {
                x = x - 20;
                a++;
            }
            while (x >= 10)
            {
                x = x - 10;
                a++;
            }
            while (x >= 5)
            {
                x = x - 5;
                a++;
            }
            while (x >= 2)
            {
                x = x - 2;
                a++;
            }
            while (x >= 1)
            {
                x = x - 1;
                a++;
            }
            Console.WriteLine(a);

        }
    }
}
