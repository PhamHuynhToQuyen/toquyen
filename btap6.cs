using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToQuyen_BtapCSDL
{
    internal class btap6
    {
        static void Cau6 (string[] args)
        {
            Console.WriteLine($"kich thuoc cua int: {sizeof(int)} bytes");
            Console.WriteLine($"kich thuoc cua float: {sizeof(float)} bytes");
            Console.WriteLine($"kich thuoc cua double: {sizeof(double)} bytes");
            Console.WriteLine($"kich thuoc cua char: {sizeof(char)} bytes");
            Console.WriteLine($"kich thuoc cua bool: {sizeof(bool)} bytes");
        }
    }
}
