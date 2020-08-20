using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());
            int br = 0;
            int b = 0;
            for (char i = 'A'; i <= a; i++) 
            {
                br++;
                for (int j = 1; j <= row + br-1; j++) 
                {
                    if (j % 2 != 0) 
                    {
                        for(char k=(char)97;k<(char)97+seat;k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            b++;
                        }
                    }
                    else
                    {
                        for (char k = (char)97; k < (char)97 + seat + 2; k++) 
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            b++;
                        }
                    }
                    
                }
            }
            Console.WriteLine(b);

        }
    }
}
