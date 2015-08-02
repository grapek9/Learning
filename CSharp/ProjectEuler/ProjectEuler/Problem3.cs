using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem3
    {
        public void run()
        {
            long number = 600851475143;
            Console.Write("The highest prime factor is :"+ generateListOfPrimeFactors(number).Max());
        }
        public IEnumerable<int> generateListOfPrimeFactors(long number)
        {
            int prime_factor = 2;
            do
            {
                if (number % prime_factor == 0)
                {
                    number = number / prime_factor;
                    Console.WriteLine(prime_factor);
                    yield return prime_factor;
                }
                else
                {
                    do
                    {
                        prime_factor++;
                    } while (isPrime(prime_factor)!=true);
                }
            } while (number > 1);
            yield break;
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
    }
}
