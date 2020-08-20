using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            int flag = 0;
            for(int row=1;row<=n;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    if(current>n)
                    {
                       flag = 1;
                       break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
                if(flag==1)
                {
                    break;
                }
            }
        }
    }
}
