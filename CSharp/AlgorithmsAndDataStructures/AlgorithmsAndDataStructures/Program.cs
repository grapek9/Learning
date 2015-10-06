using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] charArray = new String[5] {"ax","az","aa","ad","ac"};
            foreach(String i in charArray) {
                Console.Write(i+",");
            }
            charArray = BubbleSort.runBubbleSort(charArray);
            Console.WriteLine();
            foreach (String i in charArray)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
