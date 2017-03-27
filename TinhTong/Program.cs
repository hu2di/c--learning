using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Chuong trinh tinh 1 + 1/2 + 1/3 + 1/4 + ... + 1/n");
        lable:
            Console.Write("n = ");
            int n;
            n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int iCount = 1; iCount <= n; iCount++)
            {
                sum = sum + 1 / Convert.ToDouble(iCount);
            }
            Console.WriteLine("Ket qua: {0}", sum);
            goto lable;
            #endregion
            Console.ReadLine();
        }
    }
}
