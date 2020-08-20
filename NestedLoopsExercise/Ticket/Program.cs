using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            int sum = 0;
            for (char a = 'B'; a <= 'L'; a++) 
            {
                
                for (char b = 'f'; b >= 'a'; b--) 
                {
                    for (char c = 'A'; c <= 'C'; c++) 
                    {
                        for (int d = 1; d <= 10; d++) 
                        {
                            for (int e = 10; e >= 1; e--)
                            {
                                if ((int)a % 2 == 0)
                                {
                                    br++;
                                }
                                if (br == n)
                                {
                                    sum = a + b + c + d + e;
                                    Console.WriteLine($"Ticket combination: {a}{b}{c}{d}{e}");
                                    Console.WriteLine($"Prize: {sum} lv.");
                                    return;
                                }
                                    
                            }
                        }
                    }
                }
            }
        }
    }
}
