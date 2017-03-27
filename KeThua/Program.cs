using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            D x = new D();
            x.m();
            C x1 = new D();
            x1.m();
            Console.ReadLine();
        }
        class C
        {
            //public A()
            //{
            //    Console.Write("A");
            //}
            //public A(int x)
            //{
            //    Console.Write("A1");
            //}
            public virtual void m()
            {
                Console.Write("G");
            }
        }
        class D : C
        {
            //public B(){}
            public override void m()
            {
                Console.WriteLine("E");
            }
        }
    }
}
