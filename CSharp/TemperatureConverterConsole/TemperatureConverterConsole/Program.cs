using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature=0;
            int loop = 0;
            Console.WriteLine("Welcome To Temperature converter");
            string input;
            do{
                Console.WriteLine("Type base notation");
                Console.WriteLine("0) Exit, 1)Celsius, 2)Kelvin, 3)Fahrenheit");
                input = Console.ReadLine();
                Int32.TryParse(input, out loop);
                switch(loop){
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Input Celsius degrees");
                        input = Console.ReadLine();
                        Double.TryParse(input, out temperature);
                        display.celsius(temperature);
                        break;
                    case 2:
                        Console.WriteLine("Input Kelvin degrees");
                        input = Console.ReadLine();
                        Double.TryParse(input, out temperature);
                        display.kelvin(temperature);
                        break;
                    case 3:
                        Console.WriteLine("Input Fahrenheit degrees");
                        input = Console.ReadLine();
                        Double.TryParse(input, out temperature);
                        display.fahrenheit(temperature);
                        break;
                    default:
                        Console.WriteLine("It's "+ input+" not an option");
                        break;
                }
            }while(loop != 0);
        }
    }
}
