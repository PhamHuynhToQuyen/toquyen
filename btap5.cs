using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class btap5
    {
        static void Cau5 (string[] args)
        {
            Console.Write("Dien nhiet do (C la Celsius, F la Fahrenheit): ");
            char unit = char.ToUpper(Console.ReadLine()[0]);

            if (unit == 'C')
            {
                Console.Write("Dien nhiet do theo do C: ");
                float celsius = float.Parse(Console.ReadLine());
                float fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C bang {fahrenheit}°F.");
            }
            else if (unit == 'F')
            {
                Console.Write("Dien nhiet do theo do F: ");
                float fahrenheit = float.Parse(Console.ReadLine());
                float celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F bang {celsius}°C.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
