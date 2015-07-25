using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceForFloor
{
    class calculate
    {
        public static void input()
        {
            double costForTile=0, Height=0, Width=0;
            Console.Write("Cost for single tile:");
            costForTile = double.Parse(Console.ReadLine());
            Console.Write("Height:");
            Height = double.Parse(Console.ReadLine());
            Console.Write("Width:");
            Width = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("It will cost you:"+calculation(Width,Height,costForTile));
        }
        public static double calculation(double width,double height,double costForTile)
        {
            return costForTile*width*height;
        }
    }
}
