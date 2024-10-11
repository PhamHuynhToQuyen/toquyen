using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Btap8
    {
        static void Cau8 (string[] args)
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            float a = float.Parse(Console.ReadLine());

            float area = (float)Math.PI * a * a;
            Console.WriteLine($"Dien tich hinh tron la: {area}");
        }
    }
}
