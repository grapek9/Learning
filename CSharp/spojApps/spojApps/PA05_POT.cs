using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class PA05_POT
    {
        public void run() {
            String input;
            Console.WriteLine("Type number of tests");
            input = Console.ReadLine();
            int range;
            try {
                range = Int32.Parse(input);
                values(range); 
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
            
        }
        public void values(int range) {
            Console.WriteLine("Type base and after space exponent(power)");
            String input;    
            try
            {
                for (int i = 0; i < range; i++)
                {
                    input = Console.ReadLine();
                    factorization(input);
                }
              }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void factorization(String input) 
        {
            String[] digits = input.Split(' ');
            try
            {
                int base_ = Int32.Parse(digits[0]);
                int exponent = Int32.Parse(digits[1]);
                display((int)Math.Pow(base_,exponent));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void display(int digit) { Console.WriteLine("Last Digit:"+(digit - ((digit / 10) * 10)) / 1); }
    }
}
