using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBinAndBinToDeC
{
    class translation
    {
        public static void DecToBin()
        {
            int DecDigit = 0; String input; int temporary = 0;
            Console.WriteLine("Type Number you want to convert to Bin");
            input = Console.ReadLine();
            Int32.TryParse(input, out DecDigit);
            int[] array = new int[300];
            do{
                if (DecDigit % 2 == 0)
                {           
                    array[temporary] = 0;
                }
                else
                {        
                    array[temporary] = 1;
                }
                temporary++;
                DecDigit = DecDigit / 2;
            }while(DecDigit>0);
         
            Console.WriteLine("Number "+input+" in binary will be :");
            Array.Reverse(array,0,temporary);
            for (int i = 0; i < temporary; i++)
            {
                Console.Write(array[i]);
            }
        }
        public static void BinToDec()
        {
            String input; int stringLength = 0;
            int decimalNumber = 0;
            Console.WriteLine("Type Binary number you wish to convert to decimal");
            input = Console.ReadLine();
            stringLength = input.Length;
           // Console.WriteLine(stringLength);
            string[] stringArray = input.Select(c => c.ToString()).ToArray();
            for (int i = 0; i < stringLength; i++ )
            {
                if(String.Compare(stringArray[i],"1",true)!=0){
                    decimalNumber+=(int)Math.Pow(2,i);
                }
            }
            Console.WriteLine("Binary number "+input+" will be "+decimalNumber+" in decimal notation");
        }
        
    }
}
