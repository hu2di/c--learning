using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraDauVao
{
    class Program
    {
        static void Main(string[] args)
        {
            char cData;
            Console.WriteLine("Moi ban nhap vao 1 ki tu:");
            cData = char.Parse(Console.ReadLine());
            if (char.IsNumber(cData))
            {
                Console.WriteLine("Day la so!");
            }
            else if (char.IsLower(cData))
            {
                Console.WriteLine("Day la chu thuong!");
            }
            else if (char.IsUpper(cData))
            {
                Console.WriteLine("Day la chu hoa!");
            }
            else
            {
                Console.WriteLine("Chuong trinh bo tay!");
            }
            Console.ReadLine();
        }
    }
}
