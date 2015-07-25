using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class NWD
    {
        public void run()
        {
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
            Console.WriteLine(Greatest_Common_Divisor(Int32.Parse(text[0].ToString()), Int32.Parse(text[2].ToString())));
        }
        public int Greatest_Common_Divisor(int first_value,int second_value)
        {
            int temporary;
            while(second_value!=0){
                temporary = second_value;
                second_value = first_value % second_value;
                first_value = temporary;
            }
            return first_value;
        }
    }
}
