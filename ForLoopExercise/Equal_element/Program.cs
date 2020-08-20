using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;
            for(int i=0;i<n;i++)
            {
               int num = int.Parse(Console.ReadLine());
                sum += num;
                if(num>max)
                {
                    max = num;
                }
            }
            
            if(sum-max==max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum= {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff= {Math.Abs(sum-max-max)}");
            }
        }
    }
}
