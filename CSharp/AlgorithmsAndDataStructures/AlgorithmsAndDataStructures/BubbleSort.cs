using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AlgorithmsAndDataStructures
{
    class BubbleSort
    {
        public static T[] runBubbleSort<T>(T[] values) where T:IComparable
        {
            T temp;
             for(int i = 0; i < values.Length; i ++)
            {
                for (int j = 0; j < values.Length-1; j++) {
                    if (values[j].CompareTo(values[j + 1]) == 1)
                    {
                        temp = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = temp;
                    }
                }
            }
            return values;
        }
    }
    
}
