using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_sec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            if(sum>=0&&sum<=59)
            {
                if (sum < 10)
                {
                    Console.WriteLine($"0:0{sum}");
                }
                else
                { Console.WriteLine("0:{0}", sum); }
                
            }
            else if(sum>=60&&sum<=119)
            {
                if((sum-60)<10)
                {
                    Console.WriteLine("1:0{0}", sum - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", sum - 60);
                }
            }
            else if(sum>=120&&sum<=179)
            {
                if((sum-120)<10)
                {
                    Console.WriteLine("2:0{0}", sum - 120);
                }
                else
                {
                   Console.WriteLine("2:{0}", sum-120);
                }
               
               
            }
            else if(sum<10)
            {
                
                Console.WriteLine($"0:0");
            }

        }
    }
}
