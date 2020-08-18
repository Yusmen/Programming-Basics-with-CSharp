using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double c = 1;
            double sum = 0;
            while (c <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum = sum + grade;
                    c++;
                }
                else
                {
                    grade = double.Parse(Console.ReadLine());
                    if (grade < 4.00)
                    {
                        break;
                    }
                }


            }
            sum = sum / 12;
            if (c == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {c} grade");
            }
        }
    }
}
