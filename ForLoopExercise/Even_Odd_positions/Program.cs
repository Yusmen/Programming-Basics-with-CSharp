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
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin =double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax =double.MinValue;
            if (n == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
                return;
            }
          
            for ( int i=1;i<=n;i++)
            {
                double num = double.Parse(Console.ReadLine());
                if(n==1)
                {
                    if(num%2==0)
                    {
                        Console.WriteLine($"OddSum=0");
                        Console.WriteLine($"OddMin=No");
                        Console.WriteLine($"OddMax=No");
                        Console.WriteLine($"EvenSum={num}");
                        Console.WriteLine($"EvenMin={num}");
                        Console.WriteLine($"EvenMax={num}");
                        return;

                    }
                   else if(num%2!=0)
                    {
                        Console.WriteLine($"OddSum={num}");
                        Console.WriteLine($"OddMin={num}");
                        Console.WriteLine($"OddMax={num}");
                        Console.WriteLine($"EvenSum=0");
                        Console.WriteLine($"EvenMin=No");
                        Console.WriteLine($"EvenMax=No");
                        return;

                    }
                }
                if(i%2==0)
                {
                    EvenSum += num;
                    if(num>EvenMax)
                    {
                        EvenMax = num;
                    }
                     if(num<EvenMin)
                    {
                        EvenMin = num;
                    }
                }
               
                if(i%2!=0)
                {
                    OddSum += num;
                    if (num > OddMax)
                    {
                        OddMax = num;
                    }
                     if (num < OddMin)
                    {
                        OddMin = num;
                    }
                }
                
            }
            
         
            
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine($"EvenMin={EvenMin}");
                Console.WriteLine($"EvenMax={EvenMax}");
               
            
         
           
        }
    }
}
