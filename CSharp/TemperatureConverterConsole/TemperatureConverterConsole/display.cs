using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterConsole
{
    class display
    {
        public static void celsius(double temperature){
            Console.WriteLine("Celsius degres:"+temperature);
            Console.WriteLine("Kelvin degres:" + (temperature+273.15));  
            Console.WriteLine("Fahrenheit degres:" + ((temperature - 32) * (5.0 / 9)));
        }
        public static void fahrenheit(double temperature){
            Console.WriteLine("Fahrenheit degres:" + temperature);
            Console.WriteLine("Kelvin degres:" + (temperature + 273.15));
            Console.WriteLine("Celsius degres:" + ((temperature - 32) * (5.0 / 9)));
        }
        public static void kelvin(double temperature)
        {
            Console.WriteLine("Kelvin degres:" + temperature);
            Console.WriteLine("Celsius degres:" + (temperature - 273.15));
            Console.WriteLine("Fahrenheit degres:" + ((temperature - 305.15) * (5.0 / 9)));
        }
    }
}
