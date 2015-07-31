using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        public void run()
        {
            int iterator=0;
            IEnumerable<int> listOfPrimes = generatePrimes();
            foreach (int element in listOfPrimes)
            {
                iterator++;
                Console.WriteLine(iterator+") "+element);
            }
        }
        public IEnumerable<int> generatePrimes()
        {
            int number = 2;
            int counter = 0;
            do
            {
                if (isPrime(number))
                {
                    yield return number;
                    counter++;
                }
                number++;
            } while (counter != 10001);
            yield break;
        }

        public bool isPrime(int number)
        {
            int counter = 0;
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0) { counter++; }
            }
            return (counter > 2)? false : true;
        }
    }
}
