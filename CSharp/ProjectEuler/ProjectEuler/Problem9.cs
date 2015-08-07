using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem9
    {
        public void run()
        {
            int a = 1, b = 2, c = 3;
            do
            {
                if((Math.Pow(a,2)+ Math.Pow(b, 2))== Math.Pow(c, 2))
                {
                    Console.WriteLine(a + " " + b + " " + c);
                    
                }
                a++;
                b++;
                c++;
            } while (a + b + c != 1000);
        }
    }
}
