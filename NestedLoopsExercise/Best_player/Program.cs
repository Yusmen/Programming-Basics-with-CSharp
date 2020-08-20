using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_player
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = string.Empty;
            int max = 0;

            while (true) 
            {
                string name = Console.ReadLine();
                if (name == "END") 
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());
                if (goals >= 10) 
                {
                    Console.WriteLine($"{name} is the best player!");
                    Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                    return;
                }
                if (goals > max) 
                {
                    max = goals;
                    n = name;
                }
                
            }
            if (max >= 3) 
            {
                Console.WriteLine($"{n} is the best player!");
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
            }
            else
            {
                if (max < 3) 
                {
                    Console.WriteLine($"{n} is the best player!");
                   Console.WriteLine($"He has scored {max} goals.");
                }
            }
            
        }
    }
}
