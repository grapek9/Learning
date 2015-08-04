using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem12
    {
        public void run()
        {
            int number=0;
            do
            {

                number++;
                Console.Clear();Console.WriteLine(number);
            } while (FindDivisors(number) != true);
            Console.WriteLine(number);
            
        }
        public bool FindDivisors(int number)
        {
            int counter = 0;
            
            for(int i=1;i<= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter >= 500) return true; else return false;
            
        }
    }
}
