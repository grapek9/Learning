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
        public static T[] runBubbleSort<T>(T[] values)
        {
            Type typeOfValues = typeof(T);
            T temp;
            for(int i = 0; i < values.Length; i++)
            {
                for(int j = 0; j < values.Length-1; j++)
                {
                    if (typeOfValues == typeof(double))
                    {
                        if (compareValues(Convert.ToDouble(values[j]), Convert.ToDouble(values[j + 1])))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                            
                        }
                    }
                    else if (typeOfValues == typeof(float)) {
                        if (compareValues(Convert.ToString(values[j]), Convert.ToString(values[j + 1])))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }
                    else
                    {
                        if (compareValues(Convert.ToInt32(values[j]), Convert.ToInt32(values[j + 1])))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }

                }
            }
            return values;
        }
        public static bool compareValues(int firstArg,int secondArg)
        {
            if (firstArg > secondArg) return true;
            return false;
        }
        public static bool compareValues(String firstArg, String secondArg)
        {
            if (float.Parse(firstArg) > float.Parse(secondArg)) return true;
            return false;
        }
        public static bool compareValues(double firstArg, double secondArg)
        {
            if (firstArg > secondArg) return true;
            return false;
        }
    }
    
}
