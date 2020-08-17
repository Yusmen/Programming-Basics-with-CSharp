using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int chasizpit = int.Parse(Console.ReadLine());
            int minizpit = int.Parse(Console.ReadLine());
            int chaspr = int.Parse(Console.ReadLine());
            int minpr = int.Parse(Console.ReadLine());
            int mini = chasizpit * 60 + minizpit;
            int minp = chaspr * 60 + minpr;
            int d = mini - minp;
            int h = 0;
            if(d>=0&&d<=30)
            {
                if(d==0)
                {
                   Console.WriteLine("On time");
                }
                else if(d<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{d} minutes before the start");
                }
                
                
            }
            else if(d<0&&d>-60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{minp-mini} minutes after the start");
            }
            else if(d==-60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("1:00 hours after the start");
            }
            else if(d>30&&d<60)
            {
                Console.WriteLine("Early");
                
                Console.WriteLine($"{d} minutes before the start");
            }
            else if(d==60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("1:00 hours before the start");
            }
            else if(d>60)
            {
                while(d>59)
                {
                    h++;
                    d = d - 60;
                }
                if(d<10)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{h}:0{d} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{h}:{d} hours before the start");
                }
                
            }
            else if(d<-60)
            {
                double x = Math.Abs(d);
                while(x>59)
                {
                    h++;
                    x = x - 60;
                }
                if (x < 10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{h}:0{x} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{h}:{x} hours after the start");
                }
            }


       
                    
        }
    }
}
