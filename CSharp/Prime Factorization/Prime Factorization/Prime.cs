using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Factorization
{
    class Prime
    {
        public static void display(int number)
        {
            for (int i = 1; i <= number;i++ )
            {
               
                if (isPrime(i))
                {
                    Console.Write(i+" ");
                }
                
            }
        }
        public static bool isPrime(int number)
        {   
            int counter=0;
            for (int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    counter += 1;
                }
            }
            if(counter<=2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
