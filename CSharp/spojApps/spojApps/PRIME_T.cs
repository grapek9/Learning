using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class PRIME_T
    {
        public void run(){
            String input;
            Console.WriteLine("Tell me how many test you want to run ");
            input = Console.ReadLine();

            try
            {
                int range = Int32.Parse(input);
               int[] array = new int[range];
             //  Console.WriteLine("input "+ input);
               for (int i = 0; i < range; i++) {
                   input = Console.ReadLine();
                    array[i]=Int32.Parse(input);
                  //  Console.WriteLine(i);
               }
               foreach(int iteration in array)
               { isprime(iteration); }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
        
        }
        public void isprime(int element) {
            if (element == 1) { Console.WriteLine("Number 1 is not taking part in this competition"); return; }
            if (element == 2) { Console.WriteLine("Is 2 prime ? : YES"); return; }
            for (int i = 2; i < element; i++) {
                if (element % i == 0) { Console.WriteLine("Is "+element+" prime ? : NO"); return; }
            }
            Console.WriteLine("Is " + element + " prime ? : YES");
        }
    }
}
