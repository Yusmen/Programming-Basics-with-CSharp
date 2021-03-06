﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                double result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($" {n1} + {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($" {n1} + {n2} = {result} - odd");
                }


            }
            else if (operation == "-")
            {
                double result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($" {n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($" {n1} - {n2} = {result} - odd");
                }

            }
            else if (operation == "*")
            {
                double result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($" {n1} *{ n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($" {n1} * {n2} = {result} - odd");
                }

            }
            else if (operation == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2:f2} ");
                }
                
            }
            else if(operation == "%")
            {
                if(n2==0)
                {
                    Console.WriteLine($"Cannot divide { n1} by zero");
                }
                else
                {
                   Console.WriteLine($"{n1} % {n2} = {n1 % n2} ");
                }
                
            }




        }
    }
}
