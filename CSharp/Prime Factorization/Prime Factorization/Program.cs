using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int number;
            Console.WriteLine("Welcome To Prime Factorization Program");
            Console.WriteLine("Program Will Display Prime Numbers until reach number entered by you");
            input = Console.ReadLine();
            Int32.TryParse(input, out number);
            Console.Clear();
            Console.WriteLine("All Prime Numbers from 1 to "+number+" are:");
            Prime.display(number);
            Console.ReadKey();
        }
    }
}
