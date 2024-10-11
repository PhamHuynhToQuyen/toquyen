using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class btap3
    {
        static void Cau3 (string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            int product = a * b;
            Console.WriteLine($"Tich cua hai so la: {product}");
        }
    }
}
