using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem21
    {
        public void run()
        {
            IEnumerable<String> AmicablePairs = getAmicablePairs();
            foreach(String element in AmicablePairs)
            {
                Console.WriteLine(element);
            }
        }
        public IEnumerable<String> getAmicablePairs()
        {
            int iteration = 2;
            int sum1 = 0;
            int sum2 = 0;
            do {
                sum1 = sumOfDivisors(iteration);
                sum2 = sumOfDivisors(sum1);
                if (sum2 == iteration && sum2!=sum1)
                {
                    yield return sum2.ToString() + " " + sum1.ToString();
                }
                iteration++;
            } while (iteration!=10000);
        }
        public int sumOfDivisors(int number)
        {
            int sum = 0;
            for(int i  = 1; i < number; i++)
            {
                if (number % i == 0) sum += i;
            }
            return sum;
        }    
    }
}
