using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem16
    {
        public void run()
        {
            int sum = 0;
            BigInteger poweredDigit = (BigInteger)Math.Pow(2, 1000);
            String value = poweredDigit.ToString();
            for(int i = 0; i < value.Length; i++)
            {
                sum += int.Parse(value[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
