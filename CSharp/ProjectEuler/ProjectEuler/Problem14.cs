using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem14
    {
        public void run()
        {
            int startingValue = 13;
            
            CollatzSequence(startingValue);
        }
        public void CollatzSequence(int number)
        {
            Console.Write("Begins With-> 13 ->");
            do
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                    Console.Write(number+"->");
                }
                else
                {
                    number = 3 * number + 1;
                    Console.Write(number + "->");
                }
            } while (number != 1);
        }
    }
}
