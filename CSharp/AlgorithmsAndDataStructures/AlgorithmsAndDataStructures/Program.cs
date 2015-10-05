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
            char[] charArray = new char[5] {'b','x','z','o','a'};
            foreach(char i in charArray) {
                Console.Write(i+",");
            }
            charArray = BubbleSort.runBubbleSort(charArray);
            Console.WriteLine();
            foreach (char i in charArray)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
