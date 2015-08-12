using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem30
    {
        public void run()
        {
            IEnumerable<int> sequenceOfvalues = generateSequence();
            foreach (int element in sequenceOfvalues)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Sum of all elements :"+sequenceOfvalues.Sum());
            

        }
        public IEnumerable<int> generateSequence()
        {
            for(int i = 2; i < 550000; i++)
            {
                if (sumOfElements(i))
                {
                    yield return i;
                }
            }
        }
        public bool sumOfElements(int number)
        {
            string numberAsText = number.ToString();
            int sum = 0;
            for(int i = 0; i < numberAsText.Length; i++)
            {
                sum += (int)Math.Pow(int.Parse(numberAsText[i].ToString()),5);
            }
            if (sum == number) return true; else return false;
        }
    }
}
