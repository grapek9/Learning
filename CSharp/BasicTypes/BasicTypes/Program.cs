using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int loop_control=0;
            Console.Out.WriteLine("C# Basic Types Guide With Examples");
            do{
            try
                {
                    Console.WriteLine("1) Clear Console, 2) Numeric Types,3)Strings&Chars, 4)Collections,5)Operators,6)Dynamic Types, 0)Exit");
                        input = Console.ReadLine();
                        loop_control = Int32.Parse(input);
                      //  Console.Write(loop_control);
                        switch (loop_control)
                        {
                            case 0:
                                break;
                            case 1:
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                NumTypes.display();
                                break;
                            case 3:

                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                Console.WriteLine("There is no option like:"+loop_control);
                                break;
                        }
                }
                catch (Exception ex)
                {
                    ConsoleColor actualColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine("Error Occured:"+ex.Message);
                    Console.ForegroundColor = actualColor;
                    loop_control = -5;
                    
                }
            }while(loop_control!=0);

             
        }
    }
}
