using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_war
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int max = int.MinValue;
            string winner = string.Empty;
            while(s!="STOP")
            {
                int sum = 0;
                for(int i=0;i<s.Length;i++)
                {
                    sum += s[i];
                }
                if(sum>max)
                {
                    max = sum;
                }
                else
                {
                    if(sum==max)
                    {
                        winner = $"Winner is {s} - {sum}!";
                    }
                }
                winner= $"Winner is {s} - {sum}!";
                s = Console.ReadLine();
            }
            Console.WriteLine(winner);
        }
    }
}
