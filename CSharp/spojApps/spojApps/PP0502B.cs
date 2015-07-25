using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class PP0502B
    {
        public void run(){
            Console.WriteLine("Type number of tests");
            String input;
            input = Console.ReadLine();
            int range;
            try
            {
                range = Int32.Parse(input);
                String[] tests = new String[range];
                for (int i = 0; i < range; i++)
                {
                    input = Console.ReadLine();
                    tests[i] = input;
                }

                foreach (String iterator in tests)
                {
                    display(iterator);
                }

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public void display(String text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new String(charArray));
        }
    }
}
