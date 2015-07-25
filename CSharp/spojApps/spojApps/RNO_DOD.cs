using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace spojApps
{
    class RNO_DOD
    {
        public void run()
        {
            Console.WriteLine("Type number of tests");
            String input = Console.ReadLine();
            int range;
            try
            {
                range = Int32.Parse(input);
                for (int i = 0; i < range; i++)
                {
                    int sum = 0;
                    Console.WriteLine("Type amount of numbers you want to be added");
                    input = Console.ReadLine();
                    int digits = Int32.Parse(input);
                    Console.WriteLine("Type numbers and separete them with space");
                    input = Console.ReadLine();
                    String[] array = input.split();
                    for (int j = 0; j < digits; j++)
                    {
                        sum += Int32.Parse(array[j]);
                    }
                    Console.WriteLine(sum);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

    }
}
