using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            c = int.Parse(Console.ReadLine());
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem!");
            } else if (a == 0 && b == 0 && c!=0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            } else if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh co nghiem: {0}",-c/b);
            }
            else 
            {
                delta = b * b - 4 * a * c;
                if (delta < 0) 
                {
                    Console.WriteLine("Phuong trinh khong co nghiem thuc!");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: {0}", -b / 2 * a);
                }
                else
                {
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet: \n x1 = {0} \n x2 = {1}", (-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
            Console.ReadLine();
        }
    }
}
