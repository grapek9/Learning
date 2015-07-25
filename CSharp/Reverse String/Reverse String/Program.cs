using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("Welcome To String Reverse Program");
            Console.WriteLine("Input string you wish to reverse");
            input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You Have Inputed:");
            Console.WriteLine(input);
            Console.WriteLine("After reverse it looks like:");
            input = Reverse(input);
            Console.WriteLine(input);
            Console.ReadKey();
        }

        public static string Reverse(string toReverse)
        {
            char[] array = toReverse.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
