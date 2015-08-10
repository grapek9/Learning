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
            IEnumerable<String> TripleSequences = generateTripleSequences();
            foreach (String values in TripleSequences)
            {
                isTriplet(values.Split(','));
            }

        }
        public void isTriplet(String[] values)
        {
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
            int c = int.Parse(values[2]);
            if ((a*a+b*b)==c*c)
            {
                if(a<b && b < c)
                {
                    Console.WriteLine(values[0]+"+"+values[1]+"+"+values[2]+"=1000");
                    Console.WriteLine("Product:  "+a*b*c);
                }
                
            }
            
        }
        public IEnumerable<String> generateTripleSequences()
        {
            for (int a = 1;a<=1000;a++)
            {
                for (int b = 1;b<=1000;b++)
                {
                    for (int c = 1;c<=1000;c++)
                    {
                        if ((a + b + c) == 1000)
                        {
                            yield return (a+","+b+","+c).ToString();
                        }
                    }
                }
            }
        }
    }
}
