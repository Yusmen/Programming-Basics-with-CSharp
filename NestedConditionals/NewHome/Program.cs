using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double sum = 0;
            if (t == "Roses")
            {
                sum = n * 5.00;
                if (n > 80)
                {
                    sum = sum - sum * 0.1;
                }

            }
            else if(t=="Dahlias")
            {
                sum = n * 3.80;
                if(n>90)
                {
                    sum = sum - sum * 0.15;
                }
            }
            else if (t == "Tulips")
            {
                sum = n * 2.80;
                if(n>80)
                {
                    sum = sum - sum * 0.15;
                }
            }
            else if(t=="Narcissus")
            {
                sum = n * 3.00;
                if(n<120)
                {
                    sum = sum + sum * 0.15;
                }
            }
            else if(t=="Gladiolus")
            {
                sum = n * 2.50;
                if(n<80)
                {
                    sum = sum + sum * 0.20;
                }
            }
            if(budget>=sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {n} {t} and {budget-sum:f2} leva left.");
            }
            else if(budget < sum)
            {
                Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more.");
            }
           
            

        }
    }
}
