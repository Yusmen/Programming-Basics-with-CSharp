using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool flour = false; bool sugar = false; bool eggs = false;
            for(int i=1;i<=n;i++)
            {
                while(true)
                {
                    string c = Console.ReadLine();
                    if(c=="Bake!")
                    {
                        if(flour==true&&sugar==true&&eggs==true)
                        {
                            Console.WriteLine($"Baking batch number {i}... ");
                            flour = false;eggs = false;
                            sugar = false;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            continue;
                        }
                       
                    }
                    switch(c)
                    {
                        case "flour": flour = true; break;

                        case "eggs": eggs = true; break;

                        case "sugar": sugar = true; break;
                    }
                }
                      
            }
        }
    }
}
