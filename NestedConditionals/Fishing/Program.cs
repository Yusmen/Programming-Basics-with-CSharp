using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double sum =-1.0;
            if(s=="Spring")
            {
                sum = 3000;
            }
            else if(s=="Summer"||s=="Autumn")
            {
                sum = 4200;
            }
            else if(s=="Winter")
            {
                sum = 2600;
            }
            if(b<=6)
            {
                sum = sum - sum * 0.1;
            }
            else if(b>6&&b<=11)
            {
                sum = sum - sum * 0.15;
            }
            else if(sum>=12)
            {
                sum = sum - sum * 0.25;
            }
            if(b%2==0&&s!="Autumn")
            {
                sum = sum - sum * 0.05;
            }
            if(budget>=sum)
            {
                Console.WriteLine($"Yes! You have {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva.");
            }
        }
    }
}
