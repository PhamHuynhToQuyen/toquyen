using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Program
    {
        static void Cau1 (string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine($"Tong cua hai so la: {sum}");
        }
    }
}
