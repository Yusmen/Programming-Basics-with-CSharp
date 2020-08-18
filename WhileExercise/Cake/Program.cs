using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = a * b;
            int sum = 0;
            int pieces = 0;
            while(true)
            {
                string x = Console.ReadLine();
                if(x=="STOP")
                {
                    Console.WriteLine($"{p - sum} pieces are left.");
                    break;
                }
                int q = Convert.ToInt32(x);
                sum += q;
                if(sum>=p)
                {
                    Console.WriteLine($"No more cake left!You need {sum - p} pieces more.");
                    break;
                }
            }

        }
    }
}
