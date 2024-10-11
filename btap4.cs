using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class btap4
    {
        static void Cau4 (string[] args)
        {
            Console.Write("Dien do dai feet: ");
            float feet = float.Parse(Console.ReadLine());

            float meters = feet * 0.3048f;
            Console.WriteLine($"{feet} feet bang voi {meters} meters.");
        }
    }
}
