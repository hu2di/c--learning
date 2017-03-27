using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForandGoto
{
    class Program
    {
        static void Main(string[] args)
        {
            point:
            float max = float.MinValue;
            float input;
            Console.Write("Nhap so cac so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("So thu {0} : ", i);
                input = float.Parse(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                }
            }
            Console.WriteLine("So lon nhat trong {0} so la: {1}", n, max);
            goto point;
            Console.ReadLine();
        }
    }
}
