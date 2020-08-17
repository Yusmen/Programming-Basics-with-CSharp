using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_dressing
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            string v = Console.ReadLine();
            string Outfit=" ",Shoes=" ";
            if(d>=10&&d<=18)
            {
                if(v=="Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if(v=="Afternoon")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";

                }
                else if(v=="Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if(d>18&&d<=24)
            {
                if (v == "Morning")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";

                }
                else if (v == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";

                }
                else if (v == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";

                }

            }
            else if(d>=25)
            {
                if (v == "Morning")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";


                }
                else if (v == "Afternoon")
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";


                }
                else if (v == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";


                }
            }
            Console.WriteLine($"It's {d} degrees, get your {Outfit} and {Shoes}.");

            
        }
    }
}
