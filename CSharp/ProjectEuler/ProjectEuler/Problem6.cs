using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public void run()
        {
            int sumOfSquares = Enumerable.Range(1, 100).Sum(x => x * x);
            int squareOfSum = (int)Math.Pow(Enumerable.Range(1, 100).Sum(), 2);
            Console.WriteLine("Sum of squares "+sumOfSquares+ "\nSquare of sum " + squareOfSum+"\nDifference"+(squareOfSum-sumOfSquares));                 
        }
                
        /*
        public void run()
        {
            Console.WriteLine("Sum of squares: "+sumOfSquares());
            Console.WriteLine("Square of sum: "+squareOfSum());          
            Console.WriteLine("Difference: "+(squareOfSum()-sumOfSquares()));
        }
        public int sumOfSquares()
        {
            int sum = 0;
            for(int i = 1;i <= 100; i++)
            {
                sum += pow(i);
            }
            return sum;
        }
        public static int pow(int number)
        {
            return number * number;
        }
        public int squareOfSum()
        {
            int sum = 0;
            for(int i =1; i <= 100; i++)
            {
                sum += i;
            }
            return pow(sum);
        }*/
    }
}
