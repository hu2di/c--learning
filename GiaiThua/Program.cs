using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 1, giaiThua = 1;
            Console.Write("GIAI THUA! \nMoi ban nhap n = ");
            n = int.Parse(Console.ReadLine());
            for (count = 1; count <= n; count++)
            {
                giaiThua = giaiThua * count;
            }
            Console.WriteLine("{0}! = {1}", n, giaiThua);
            Console.ReadLine();
        }
    }
}
