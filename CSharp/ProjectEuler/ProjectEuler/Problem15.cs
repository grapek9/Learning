using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ProjectEuler
{
    class Problem15
    {
       public void run()
        {
            int numberOfMoves = 20;
            int gridSize = 40;
            Console.WriteLine(calculatePossibleWays(numberOfMoves,gridSize));
        }
        public BigInteger calculatePossibleWays(BigInteger numberOfMoves,BigInteger gridSize)
        {
            return (BigInteger)(factorial(gridSize)/(factorial(numberOfMoves)*factorial(gridSize-numberOfMoves)));
        }
        public BigInteger factorial(BigInteger number)
        {
            if (number == 1) return 1;
            return factorial(number-1)*number;
        }
    }
}
