using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        public void run()
        {
            IEnumerable<int> list = generate_list();
            display(list);
        }
        public IEnumerable<int> generate_list()
        {
            int firstArg = 1, secondArg = 1, temp = 0; 
            do{
                temp = secondArg;
                secondArg = fibbonaciSequence(firstArg, secondArg);
                firstArg = temp;
                if(secondArg%2==0){
                    yield return secondArg;
                }
            }while(secondArg<4000000);          
        }
        public int fibbonaciSequence(int firstArg,int secondArg)
        {
            return firstArg+secondArg;
        }
        public void display(IEnumerable<int> list)
        {
            int sum = 0;
            foreach (int element in list)
            {
                sum += element;
            }
            Console.WriteLine("Sum of elements : "+sum);
        }
    }
}
