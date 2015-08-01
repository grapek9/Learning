using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem10
    {
        public void run()
        {
            Console.WriteLine(generatePrimes().Sum());

        }
        public bool isPrime(int number)
        {
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) { counter++; }
            }
            return (counter > 2) ? false : true;
        }
        public IEnumerable<int> generatePrimes()
        {
            for(int i =2; i <= 2000000; i++)
            {
                if (isPrime(i))
                {
                    yield return i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
