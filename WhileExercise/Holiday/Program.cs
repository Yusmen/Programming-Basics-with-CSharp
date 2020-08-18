using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            string d = string.Empty;
            int day = 0;
            int f = 0;
            double x = default(double);
            string result = string.Empty;
            bool isSpend = false;
            while (true)
            {
                d = Console.ReadLine();
                x = double.Parse(Console.ReadLine());
                day++;
                if (d == "spend")
                {
                    n = n - x;
                    f++;
                }
                else if (d == "save")
                {
                    f = 0;
                    n = n + x;
                }

                if(n>=h)
                {
                    result = $"You saved the money for {day} days.";
                    break;
                }
                if (f == 5)
                {
                    result = "You can't save the money." + Environment.NewLine + day;
                    isSpend = true;
                    break;
                }
               
            }
            Console.WriteLine(result);
        }
    }
}
