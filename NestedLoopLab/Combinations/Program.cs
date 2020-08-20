using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for(int i=0;i<=n;i++)
            {
                
                for(int j=0;j<=n;j++)
                {
                    for(int k=0;k<=n;k++)
                    {
                        for(int p=0;p<=n;p++)
                        {
                            for(int c=0;c<=n;c++)
                            {
                                if(i+j+k+p+c==n)
                                {
                                    br++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(br);
        }
    }
}
