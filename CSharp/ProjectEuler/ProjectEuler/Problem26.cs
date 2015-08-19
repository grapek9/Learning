using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem26
    {
        public void run()
        {
            IEnumerable<String> values = generateValues();
            Console.WriteLine(values.Max(x=>x.Length));
        }
        public IEnumerable<String> generateValues() {

            for (int i = 1; i < 1000; i++)
            {
                yield return ((double)1/i).ToString();
            }
        }
    }
}
