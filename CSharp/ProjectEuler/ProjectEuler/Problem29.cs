using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ProjectEuler
{
    class Problem29
    {
        public void run()
        {
            IEnumerable<BigInteger> values = generateValues();
            Console.WriteLine(values.Count());
        }
        public IEnumerable<BigInteger> generateValues()
        {
            for(int i =2;i <= 100; i++)
            {
                for(int j = 2; j <= 100; j++)
                {
                    yield return (BigInteger)Math.Pow(i,j);
                }
            }
        }
    }
}
