using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class ExtMethods
    {
        public static int pow(this int arg) { return arg * arg; }
        public static int pow(this int arg, int power) { return (int)Math.Pow(arg, power); }
        public static double pow(this double arg) { return arg * arg; }
        public static double pow(this double arg, int power) { return Math.Pow(arg, power); }
        
       
        public static string[] split(this string text)
        {
            string[] splitedArray = text.Split(' ',',','.',';');
            return splitedArray;
        }


        public static int wordcounter(this string text)
        {
            string[] splitedArray = text.Split(' ', ',', '.', ';');
            return splitedArray.Length;
        }


        public static int[] multiply(this int[] array)
        {
            int i = 0;
            foreach (int iterator in array)
            {
                array[i] = iterator * 2;
                i++;
            }
            return array;
        }


        public static int[] multiply(this int[] array,int value)
        {
            int i = 0;
            foreach (int iterator in array)
            {
                array[i] = iterator * value;
                i++;
            }
            return array;
        }


        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
          foreach(T item in collection)
             action(item);
        }
        public static int[] BubbleSort(this int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
                return array;
        }
        public static int[] SelectionSort(this int[] array)
        {
            int pos_min=0;
            int temp=0;
            for (int i = 0; i < array.Length-1; i++)
            {
                pos_min = i;
                for (int j = i + 1; j< array.Length; j++)
                {
                    if (array[j] < array[pos_min])
                    {
                        pos_min = j;
                    }
                }
                temp = array[i];
                array[i] = array[pos_min];
                array[pos_min] = temp;
            }
                return array;
        }

        /*public static T[] BubbleSort<T>(this T[] array)
        {
            T temporary;
            for (int loop1 = 0; loop1 < array.Length; loop1++)
            {
                for (int loop2 = 0; loop2 < array.Length; loop2++)
                {
                    if (array[loop2] > array[loop2 + 1])
                    {

                    }
                }
            }
                return array;
        }*/

    }
}
