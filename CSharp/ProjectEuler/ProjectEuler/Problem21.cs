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
            IEnumerable<int> divisors = getDivisors();
            Console.WriteLine(divisors.Sum());
        }
        public IEnumerable<int> getDivisors()
        {
            int number = 220;
            for(int i = 1; i < number; i++)
            {
                if (number % i == 0) yield return i;
            }
        }
            
    }
}
