using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Btap7
    {
        static void Cau7 (string[] args)
        {
            Console.Write("Nhap ky tu: ");
            char character = Console.ReadLine()[0];
            int asciiValue = (int)character;
            Console.WriteLine($"Gia tri ASCII cua ky tu  '{character}' la {asciiValue}.");
        }
    }
}
