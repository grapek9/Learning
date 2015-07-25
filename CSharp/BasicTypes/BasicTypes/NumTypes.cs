using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class NumTypes
    {
        public static void display()
        {
            string input;
            int loop_control = 0;
            do
            {
                try
                {
                    Console.WriteLine("In C# we can point basic Numeric Types Like:");
                    Console.WriteLine("Sbye,Byte,Short,Int,Long,Ushort,Uint,Ulong,Float,Double,Decimal");
                    Console.WriteLine("1) Clear Console, 2) Range, 3) Amount of taken Bit's, 4) Deafault Value, 0)Exit");
                    input = Console.ReadLine();
                    loop_control = Int32.Parse(input);
                    //  Console.Write(loop_control);
                    switch (loop_control)
                    {
                        case 0:
                            Console.Clear();
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Sbyte  -> from -127 to 128");
                            Console.WriteLine("Byte   -> from 0 to 255 ");
                            Console.WriteLine("Short  -> from -32 768 to 32 767");
                            Console.WriteLine("Int    -> from -2 147 483 648 to 2 147 483 647");
                            Console.WriteLine("Long   -> from -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807");
                            Console.WriteLine("UShort -> max 65 535");
                            Console.WriteLine("Uint   -> max 4 294 967 295");
                            Console.WriteLine("Ulong  -> max 18 446 744 073 709 551 615");
                            Console.WriteLine("Float  -> Single Precision from ~1,4*10^-45 to ~3,403*10^38");
                            Console.WriteLine("Double -> Double Precision from ~4,9*10^-324 to ~1,798*10^308");
                            Console.WriteLine("Decimal-> From 10^-28 to 7,9*10^28");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("Sbyte  -> 8bit with sign");
                            Console.WriteLine("Byte   -> 8bit without sign");
                            Console.WriteLine("Short  -> 2bytes = 16bit with sign");
                            Console.WriteLine("Int    -> 4bytes = 32bit with sign ");
                            Console.WriteLine("Long   -> 8bytes = 64bit with sign");
                            Console.WriteLine("UShort -> 2bytes = 16bit without sign");
                            Console.WriteLine("Uint   -> 4bytes = 32bit without sign");
                            Console.WriteLine("Ulong  -> 8bytes = 64bit without sign");
                            Console.WriteLine("Float  -> 4bytes (float notation)");
                            Console.WriteLine("Double -> 8bytes (float notation)");
                            Console.WriteLine("Decimal-> 16bytes (better precision but smaller range than double)");
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.WriteLine("Sbyte  -> 0");
                            Console.WriteLine("Byte   -> 0");
                            Console.WriteLine("Short  -> 0");
                            Console.WriteLine("Int    -> 0");
                            Console.WriteLine("Long   -> 0L");
                            Console.WriteLine("UShort -> 0");
                            Console.WriteLine("Uint   -> 0");
                            Console.WriteLine("Ulong  -> 0L");
                            Console.WriteLine("Float  -> 0.0F");
                            Console.WriteLine("Double -> 0.00");
                            Console.WriteLine("Decimal-> 0.0M");
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("There is no option like:" + loop_control);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ConsoleColor actualColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine("Error Occured:" + ex.Message);
                    Console.ForegroundColor = actualColor;
                    loop_control = -5;

                }
            } while (loop_control != 0);
            Console.Clear();
        }
    }
}
