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
                        if (compareValues(float.Parse(Convert.ToString(values[j])), float.Parse(Convert.ToString(values[j + 1]))))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }
                    else if(typeOfValues == typeof(int))
                    {
                        if (compareValues(Convert.ToInt32(values[j]), Convert.ToInt32(values[j + 1])))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }
                    else if (typeOfValues == typeof(char))
                    {
                        if (compareValues(char.Parse(values[j].ToString()), char.Parse(values[j + 1].ToString())))
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }
                    else
                    {
                        if (compareValues(values[j].ToString(), values[j + 1].ToString()))
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
        public static bool compareValues(float firstArg, float secondArg)
        {
            if (firstArg > secondArg) return true;
            return false;
        }
        public static bool compareValues(double firstArg, double secondArg)
        {
            if (firstArg > secondArg) return true;
            return false;
        }
        public static bool compareValues(char firstArg, char secondArg)
        {
            if (firstArg > secondArg) return true;
            return false;
        }
        public static bool compareValues(String firstArg, String secondArg)
        {
            if (firstArg.CompareTo(secondArg) > 0) {  return true; }
            return false;
        }
    }
    
}
