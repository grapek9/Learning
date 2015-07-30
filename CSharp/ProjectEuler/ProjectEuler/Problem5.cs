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
            int range = 20;
            int smallest = 1;
            for(int i=1;i< range;i++)
            {
                Console.WriteLine("stuff "+smallest+"*"+i);
                smallest *= i;
            }
            return smallest;
        }
        
    }
}
