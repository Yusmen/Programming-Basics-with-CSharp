using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            int a = 0;
            int f = 0;
            while(a<c)
            {
                string x = Console.ReadLine();
                if(x==b)
                {
                    f = 1;break;
                }
                a++;
                if(a==c)
                {
                    break;
                }
            }
            if(f==1)
            {
                Console.WriteLine($"You checked {a} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {a} books.");
            }
        }
    }
}
