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
            Int64 number = 600851475143;
            IEnumerable<int> list = generateListOfPrimeFactors(number);
            Console.Write("The highest prime factor is :"+list.Max());
        }
        public IEnumerable<int> generateListOfPrimeFactors(Int64 number)
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
            int counter = 1;
            for(int i = 2; i<= number; i++)
            {
                if (number % i != 0)
                {
                    counter++;
                }
            }
            return (counter>2)? true :false;
        }
    }
}
