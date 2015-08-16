using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem20
    {
        public void run()
        {
            Console.WriteLine(sum(factorial(100)));
        }
        public BigInteger factorial(int number)
        {
            if (number == 1) return 1;
            return factorial(number - 1) * number;
        }
        public int sum(BigInteger number)
        {
            String value = number.ToString();
            int sum = 0;
            for(int i= 0; i < value.Length; i++)
            {
                sum +=int.Parse(value[i].ToString());
            }
            return sum;
        }
    }
}
