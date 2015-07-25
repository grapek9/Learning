using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionLearning
{
    class Program
    {
        delegate int SquareRoot(int n);
        static void Main(string[] args)
        {
            SquareRoot value = (int n) => n * n;
            Console.WriteLine("Square root of 5 is "+value(5));
            Console.ReadKey();

        }
    }
}
