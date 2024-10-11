using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class Btap10
    {
        static void Main (string[] args)
        {
            Console.Write("Nhap so ngay: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;
            days %= 365;
            int weeks = days / 7;
            days %= 7;

            Console.WriteLine($"{years} nam, {weeks} tuan, va {days} ngay.");
        }
    }
}
