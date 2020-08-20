using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for(int i=level;i>=1;i--)
            {
                for(int j=0;j<room; j++)
                {
                    if(i%2!=0&&i!=level)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    else if(i%2==0&&i!=level)
                    {
                        
                        Console.Write($"O{i}{j} ");
                    }
                    if(i==level)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                }
                Console.WriteLine();
                
            }
        }
    }
}
