using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            double sreden = 0;
            int numproblem = 0;
            int bad = 0;
            string lastProblem = string.Empty;
            while (true)
            {
                string name = Console.ReadLine();
              
                if (name=="Enough")
                {
                    double averageGrade = sreden / numproblem;
                    Console.WriteLine($"Average score: {sreden / (numproblem):f2}");
                    Console.WriteLine($"Number of problems: {numproblem}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                   bad++;
                }
               if(bad==br)
                {
                    Console.WriteLine($"You need a break, {br} poor grades.");break;
                }
                lastProblem = name;
                numproblem++;
                sreden += grade;


            }
          

        }
    }
}
