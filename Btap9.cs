using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Btap9
    {
        static void Cau9 (string[] args)
        {
            Console.Write("Nhap canh hinh vuong: ");
            float a = float.Parse(Console.ReadLine());

            float area = a * a;
            Console.WriteLine($"Dien tich hinh vuong la: {area}");
        }
    }
}
