using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class FCTRL3
    {
        public void run()
        {
            String input;
            Console.WriteLine("Type number of tests");
            input = Console.ReadLine();
            int[] array;
            int range;
            try
            {
                range = Int32.Parse(input);
                array = new int[range];
                for (int i = 0; i < range; i++) {
                    input = Console.ReadLine();
                    array[i] = Int32.Parse(input);
                    }
                foreach (int iterator in array) {
                    display(iterator);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
        }
        public void display(int value) {
            value = factorial(value);
            Console.WriteLine(value/10+" "+((value-((value/10)*10))/1));
        }
        public int factorial(int value) {
            if (value == 1) return 1;
            return value*factorial(value-1); }
    }
}
