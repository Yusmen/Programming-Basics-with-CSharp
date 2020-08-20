using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=9;i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int x = 1; x <= 9; x++)
                        {
                            for (int y = 1; y <= 9; y++)
                            {
                                for (int z = 1; z <= 9; z++)
                                {
                                    if(i*j*k*x*y*z==n)
                                    {
                                        Console.Write($"{i}{j}{k}{x}{y}{z} ");
                                    }
                                }

                            }
                        }
                    }

                }





            }
        }
    }
}
