using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem34
    {
        public void run()
        {
            IEnumerable<int> values = generateValues();
            Console.WriteLine(values.Sum());
        }
        public IEnumerable<int> generateValues()
        {
            for(int i = 3; i < 1000000; i++)
            {
                if (i == resultOfFactorization(i.ToString())) yield return i;
            }
        }
        public int resultOfFactorization(String number)
        {
            int sum = 0;
            Char[] value = number.ToCharArray();
            for(int i =0;i<value.Length;i++)
            {
                Console.Write(sum);
                sum += factorization(int.Parse(value[i].ToString()));
            }
            Console.WriteLine();
            return sum;

        }
        public int factorization(int number)
        {
            int value = 1;
            for(int i =1;i<= value; i++)
            {
                value *= i;
            }
            return value;
        }
    }
}
