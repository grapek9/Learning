using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace spojApps
{
    class BFN1
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
                String[] digits = new String[range];
                for (int i = 0; i < range; i++)
                {
                    input=Console.ReadLine();
                    digits[i] = input;
                }
              
                foreach (String iterator in digits)
                {
                    display(iterator);
                }
               
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void display(String value)
        {
            bool control = false;
            int counter = 0;
            do
            {
                if (isPalindrome(value))
                {
                    Console.WriteLine(value+" "+counter);
                    control = true;
                }
                else
                {
                    Console.WriteLine(value);
                    value = increaseValue(value);
                    counter++;
                }
            } while (control == false);
        }
        public Boolean isPalindrome(String value)
        {
            Char[] array = value.ToCharArray();
            for (int i = 0; i < (value.Length)/2; i++)
            {
                if (!array[i].Equals(value.Length-1-i))
                {
                    return false;
                }
            }
                return true;
        }
        public String increaseValue(String value){
            String reversedValue = string.Join("",value.Reverse());
           // Console.WriteLine(value+" "+reversedValue);
            return (Int32.Parse(value)+Int32.Parse(reversedValue)).ToString();
        }
    }
}
