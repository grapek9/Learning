using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem25
    {
        public void run()
        {
            int index = generateIndex();
            Console.WriteLine("Index "+index);
        }
        public int generateIndex()
        {
            BigInteger value1 = 1, value2 = 0, temp = 0; ;
            int index=0;
            do
            {
                temp = value2;
                value2 = value1 + value2;
                value1 = temp;
                index++;
                Console.WriteLine(value2);
            } while (value2.ToString().Length !=1000);
            return index;
        }
    }
}
