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
            int[] intArray = new int[5] {5,2,1,6,0};
            foreach(int i in intArray) {
                Console.Write(i+",");
            }
            intArray = BubbleSort.runBubbleSort(intArray);
            Console.WriteLine();
            foreach (int i in intArray)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
