using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    class display
    {
        public static int nextprime(int last_prime){
            last_prime++;
          while (isPrime(last_prime) == false) {
                last_prime += 1;
               
            };
          
            
            return last_prime;
        }
        public static bool isPrime(int prime)
        {
            
            int counter=0;
            for (int i = 1; i <= prime; i++ )
            {
                if (prime % i == 0) counter++;
            }
            if (counter <= 2) return true;
            return false;
        }
    }
}
