using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + "\t");
                sum = sum + i;
            }
            Console.WriteLine();
            Double avg = 1.0 * sum / n;
            Console.WriteLine("Tong: {0} TrungBinhCong: {1}", sum, avg);
            Console.ReadLine();
        }
    }
}
