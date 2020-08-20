using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matric
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = c; k <= d; k++)
                    {
                        for (int p = c; p <= d; p++)
                        {
                            if (i + p == j + k && i != j && k != p)
                            {
                                Console.WriteLine($"{i}{j}");
                                Console.WriteLine($"{k}{p}");
                                Console.WriteLine();



                            }
                        }
                    }
                }

            }
        }
    }
}
