using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walk
{
    class Program
    {
        static void Main(string[] args)
        {
            int quote = int.Parse(Console.ReadLine());
            int sum = 0;
            double q = 0;
            double obshtasuma = 0;
            int br = 0;
            for(int i=0;i<quote;i++)
            {
                br++;
                string name = Console.ReadLine();
                if(name=="Stop")
                {
                    if (obshtasuma > 0)
                    {
                        Console.WriteLine("Lyubo fulfilled the quota!");
                        Console.WriteLine($"Lyubo's profit from {quote} fishes is {obshtasuma:f2} leva.");
                    }
                    else
                    {
                        Console.WriteLine($"Lyubo lost {Math.Abs(obshtasuma):f2} leva today.");
                    }
                    return;

                }
                double kg = double.Parse(Console.ReadLine());
               
                for(int j=0;j<name.Length;j++)
                {

                     sum += (int)(name[j]);

                }
                q = sum / kg;
                 if(br==3)
                {
                    obshtasuma = q - obshtasuma;
                    br = 0;
                }
                else
                {
                   obshtasuma += q;
                }
                 


            }
            if(obshtasuma>0)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
                Console.WriteLine($"Lyubo's profit from {quote} fishes is {obshtasuma:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(obshtasuma):f2} leva today.");
            }
        }
    }
}
