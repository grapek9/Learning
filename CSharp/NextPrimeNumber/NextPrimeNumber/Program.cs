using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Next Prime Number Program");
            Console.WriteLine("Program Will Display Next Prime Number until you write exit");
            Console.WriteLine("Let's begin");
            string control="test",exit="exit";
            int last_prime=2;
            Console.Write(last_prime+",");
            do{
                control=Console.ReadLine();
                last_prime=display.nextprime(last_prime);
                Console.Write(last_prime+",");

            }while(String.Compare(control,exit,true)!=0);
          
        }
    }
}
