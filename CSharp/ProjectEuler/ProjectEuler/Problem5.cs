using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5
    {
        public void run()
        {
            int smallest_positive_number = smallest_positive();
            Console.WriteLine("The smalles positive number divided by all numbers\n from 1 to 20 is : " +smallest_positive_number);
        }
        public int smallest_positive()
        {
            int number = 232792500;
            
            while (isPositive(number) == false)
            {
                number++;
                Console.WriteLine(number);
            }
            return number;
        }
        public bool isPositive(int number)
        {
            for(int i = 1; i<=20; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true ;
        }
    }
}
