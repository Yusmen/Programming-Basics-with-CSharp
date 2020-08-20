using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int first=1;first<n;first++)
            {
                for(int second=1;second<=n;second++)
                {
                    for(char  third=(char)97;third<(char)97+b;third++)
                    {
                        for(char fourth=(char)97;fourth<(char)97+b;fourth++)
                        {
                            for(int fifth=1;fifth<=n;fifth++)
                            {
                               if(fifth>first&&fifth>second)
                                {
                                    Console.Write($"{first}{second}{third}{fourth}{fifth}"+" ");
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
