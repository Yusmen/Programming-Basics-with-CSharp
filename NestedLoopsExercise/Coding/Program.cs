using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length=n.ToString().Length;
            for(int i=0;i<length;i++)
            {
                int last = n % 10;
                if(last!=0)
                {
                    for (int j = 0; j < last; j++) 
                    {

                        Console.Write((char)(last + 33));
                    }
                    Console.WriteLine();
                
                }
                else
                {
                    Console.WriteLine("ZERO");
                }
                n = n / 10;
                
            }
          
        }
    }
}
