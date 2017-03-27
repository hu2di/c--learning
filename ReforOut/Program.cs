using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReforOut
{
    class Program
    {
        static void add(ref int a)
        {
            a++;
        }
        static void sub(out int b)
        {
            //Phai khoi tao lai
            b = 5;
            b--;
        }
        static void Main(string[] args)
        {
            //Phai khoi tao re
            int re = 1;
            add(ref re);
            Console.WriteLine(re);
            //Khong quan tam gia tri dau vao cua ou
            int ou = 2;
            sub(out ou);
            Console.WriteLine(ou);
            Console.ReadLine();
        }
    }
}
