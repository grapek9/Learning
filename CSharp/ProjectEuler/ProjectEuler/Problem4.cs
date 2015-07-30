using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem4
    {
        public void run()
        {
            int largestPalindrome = generatePalindrome();
            Console.WriteLine("Largest produced palindrome: "+largestPalindrome);

        }
        public bool isPalindrome(int number)
        {
            String numberAsString = number.ToString();
            for(int i = 0; i < numberAsString.Length; i++)
            {
                if (!numberAsString[i].Equals(numberAsString[numberAsString.Length-1-i]))
                {
                    return false;
                }
            }
            return true;
        }
        public int generatePalindrome()
        {
            int Palindrome = 0;
            int firstNumber = 1, secondNumber = 1;
            do
            {
                if (isPalindrome(firstNumber * secondNumber)) Palindrome = firstNumber * secondNumber;
                Console.WriteLine(firstNumber+" "+secondNumber+" "+Palindrome);
                if(firstNumber != 999)
                {
                    firstNumber++;
                }
                else { secondNumber++; };
            } while (secondNumber < 1000);
            return Palindrome;
        }
    }
}
