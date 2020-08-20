using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++) 
            {
                string subject = Console.ReadLine();
                if (subject == "hoodie")
                {
                    sum += 30;
                }
                else if (subject == "keychain")
                {
                    sum += 4;
                }
                else if (subject == "T-shirt") 
                {
                    sum += 20;
                }
                else if (subject == "flag") 
                {
                    sum += 15;
                }
                else if(subject=="sticker")
                {
                    sum += 1;
                }
            }
           
            if(sum<=budget)
            {
                Console.WriteLine($"You bought {n} items and left with {budget - sum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget} more lv.");
            }
        }
    }
}
