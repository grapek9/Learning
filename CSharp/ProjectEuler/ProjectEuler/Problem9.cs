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
            int a = 3, b = 4,c= 5;
            do
            {
               // Console.WriteLine("test");
                if (isTriplet(a, b))
                {
                    c = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine(a+" "+b+" "+c);
                }
                else
                {
                    do
                    {
                        b++;
                        
                    } while (isTriplet(a, b) ||b<300);
                    
                }
                a++;
               // Console.WriteLine("=>>>>"+a+" "+b+" "+c);
            } while (a + b + c != 1000);
        }
        public bool isTriplet(int a,int b)
        {
            if (Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))%1==0)
            {
                return true;
            }
            return false;
        }
    }
}
