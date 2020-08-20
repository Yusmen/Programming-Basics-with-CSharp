using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changes
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for (int i = k; i <= 8; i++) 
            {
                for (int j = 9; j >= l; j--) 
                {
                    for (int q = m; q <= 8; q++) 
                    {
                        for (int p = 9; p >= n; p--) 
                        {
                           

                               if (i % 2 == 0 && j % 2 != 0 && q % 2 == 0 && p % 2 != 0)
                                {
                                   if (i == q && j == p)
                                   { 

                                    Console.WriteLine("Cannot change the same player.");

                                   }
                                   else
                                   { 

                                       Console.WriteLine($"{i}{j} - {q}{p}");
                                      br++;
                                
                                    }
                               
                                }
                            if (br == 6) 
                            {
                                return;
                            }
                                
                            
                        }
                    }
                }
            }
        }
    }
}
