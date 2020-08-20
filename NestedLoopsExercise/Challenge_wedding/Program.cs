using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int male = int.Parse(Console.ReadLine());
            int female = int.Parse(Console.ReadLine());
            int masi = int.Parse(Console.ReadLine());
            int br = 0;
            for (int i = 1; i <= male; i++) 
            {
                for (int j = 1; j <= female; j++) 
                {
                    br++;
                    if(br-1==masi)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write($"({i} <-> {j})" + " ");
                    }
                }
            }
        }
    }
}
