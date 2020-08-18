using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    class Program /*tomato, cucumber, pepper и carrot*/
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine().ToLower();
            if(x=="banana"||x=="apple"||x=="kiwi"||x=="cherry"||x=="lemon"||x=="grapes")
            {
                Console.WriteLine("fruit");
            }
            else
            {
                if(x=="tomato"||x=="cucumber"||x=="pepper"||x=="carrot")
                {
                    Console.WriteLine("vegetable");
                }
                else
                {
                    Console.WriteLine("unknown");
                }
            }
        }
    }
}
