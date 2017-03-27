using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XinChao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6 / 2 * (2 + 1);
            Console.WriteLine(a);
            String name;
            name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin chao {0}.Ban {1} tuoi", name,age);
            Console.ReadLine();
        }
    }
}
