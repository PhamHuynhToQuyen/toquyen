using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Btap2
    {
        static void Cau2 (string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Truoc khi hoan doi: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Sau khi hoan doi: a = {a}, b = {b}");
        }
    }
}
