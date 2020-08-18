using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance_account
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int a=0;
           double sum = 0.0;
            while(a!=b)
            {
                double s = double.Parse(Console.ReadLine());
                if(s<0)
                {
                    Console.WriteLine("Invalid operation!");break;
                }
                Console.WriteLine($"Increase: {s:f2}");
                sum = sum + s;
                a++;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
