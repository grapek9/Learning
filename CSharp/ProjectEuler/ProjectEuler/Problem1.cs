﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1
    {
        public void run()
        {
            Console.WriteLine("The sum equals : " + Enumerable.Range(1, 999).Where(x=> x%5==0 || x%3==0).Sum());

           /* Old code, working like that one above  
            int sum = 0;
            int[] array = Enumerable.Range(1, 999).ToArray();
            foreach (int iterator in array)
            {
                if (iterator % 3 == 0 || iterator % 5 == 0)
                {
                    sum += iterator;
                }
            }
            Console.WriteLine("Done and the sum equals : "+sum); */
        }
    }
}
