using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem13
    {
        public void run()
        {
            BigInteger sum = 0;
            System.IO.StreamReader readedValues = new System.IO.StreamReader("problem13values.txt");
            for(int i = 0; i < 100; i++)
            {
                sum += BigInteger.Parse(readedValues.ReadLine());
            }
            Console.WriteLine(sum.ToString().Substring(0,10));

        }
    }
}
