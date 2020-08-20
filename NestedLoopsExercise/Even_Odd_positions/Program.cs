using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++) 
            {
                int chetna = 0;
                int nechetna = 0;
                int process = i;

                for (int j = 0; j < 6; j++) 
                {
                    int Modul = process % 10; 

                    if (j % 2 == 0)
                    {
                        chetna += Modul;
                    }
                    else if (j % 2 != 0) 
                    {
                        nechetna+=Modul;
                    }

                    process = process / 10;

                }

                if (chetna == nechetna) 
                {
                    Console.Write(i + " ");
                }
            }
            ]=

        }
    }
}
