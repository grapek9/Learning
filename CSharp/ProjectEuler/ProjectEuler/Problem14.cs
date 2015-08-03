using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem14
    {
        public void run()
        {
            IEnumerable<int> longestChain;
            
            IEnumerable<int>[] listOfSequences = new IEnumerable<int>[1000000];
            int value = 1;
            int index = 0;
            do
            {
                 listOfSequences[value] = CollatzSequence(value);
                value++;
                if (value % 10000 == 0) { Console.Clear(); Console.WriteLine("Processing: " + (value / 10000) + "%"); };
            } while (value != 1000000);
            longestChain = listOfSequences[1];
            index = 1;
            Console.WriteLine("Sequences generated, press key to proceed to searching for longest one");
            Console.ReadKey();
            for(int i = 2; i <= 999999; i++)
            {
                if (i % 10000 == 0) { Console.Clear(); Console.WriteLine("Processing: " + (i / 10000) + "%"); };
                if (listOfSequences[i].Count() > listOfSequences[i - 1].Count())
                {
                    longestChain = listOfSequences[i];
                    index = i;
                }
            }
            Console.WriteLine("Founded, it begins with: "+index+" and has "+longestChain.Count()+" elements, keep pressing any key to see them all");
            Console.ReadKey();
            foreach(int element in longestChain)
            {
                Console.WriteLine(element+"->");
                Console.ReadKey();
            }

            
            
            
        }
        public IEnumerable<int> CollatzSequence(int number)
        {
            
          
            do
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                    
                    yield return number;
                }
                else
                {
                    number = 3 * number + 1;
                    
                    yield return number;
                }
                
            } while (number != 1);

        }
    }
}
