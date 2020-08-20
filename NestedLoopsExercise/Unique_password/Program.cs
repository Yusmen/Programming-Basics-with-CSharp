using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_password
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            for (int i = 1; i <= first; i++) 
            {

                for (int j = 1; j <= second; j++) 
                {


                    for (int k = 1; k <=third; k++) 
                    {

                        if (i % 2 == 0 && k % 2 == 0) 
                        {
                            if (j == 2 || j == 3 || j == 5)
                            {
                                Console.Write($"{i}"+ " ");
                                Console.Write($"{j}" + " ");
                                Console.Write($"{k}" + " ");
                                Console.WriteLine();
                            }
                            else
                            {
                                continue;
                            }
                           
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
