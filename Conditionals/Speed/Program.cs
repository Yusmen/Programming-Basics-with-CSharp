using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse(Console.ReadLine());
            if(s<=10)
            {
                Console.WriteLine("slow");
            }
            else if(s>10&&s<=50)
            {
                Console.WriteLine("average");
            }
            else if(s>50&&s<=150)
            {
                Console.WriteLine("fast");
            }
            else if(s>150&&s<=1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if(s>1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
