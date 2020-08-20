using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int left = 0;
                int right = 0;
                int process = i;
                for (int j = 1; j < 3; j++)
                {
                    int Modul = process % 10;
                    right += Modul;
                    process = process / 10;

                }
                int process1 = i;
                process1 = process1 / 1000;
                for(int k=1;k<3;k++)
                {
                    int Modul1 = process1 % 10;
                    left += Modul1;
                    process1 = process1 / 10;

                }
                int third = 0;
                int process2 = i;
                for(int p=1;p<5;p++)
                {
                    int Modul2 = process2 % 10;
                    if(p==3)
                    {
                        third = Modul2;break;
                    }
                    process2 = process2 / 10;
                }
                if (left==right)
                {
                    Console.Write(i+" ");
                }
                else if(left<right)
                {
                    if(left+third==right)
                    {
                        Console.Write(i+" ");
                    }
                }
                else if(right<left)
                {
                    if(right+third==left)
                    {
                        Console.Write(i+" ");
                    }
                }






             } 
        }
        
    }
}
