using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            double sumsredno = 0;
            while(true)
            {
                double sum = 0;
                double sredno = 0;

                string s = Console.ReadLine();
                if(s=="Finish")
                {
                    break;
                }
                for(int i=0;i<n;i++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    sum+= ocenka;
                }
                sredno = sum / n;
                Console.WriteLine($"{s} - {sredno:f2}.");
                sumsredno += sredno;
                br++;
            }
            Console.WriteLine($"Student's final assessment is {sumsredno / br:f2}.");

        }
    }
}
