using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int v = width * length * height;
            string s = Console.ReadLine();
            int sum = 0;
            while(s!="Done")
            {
                int a = Convert.ToInt32(s);
                sum = sum + a;
                if(sum>=v)
                {
                    Console.WriteLine($"No more free space! You need {sum-v} Cubic meters more.");break;
                }
                s = Console.ReadLine();

            }
            if(v>sum)
            {
                Console.WriteLine($"{v - sum} Cubic meters left.");
            }

          
        }
    }
}
