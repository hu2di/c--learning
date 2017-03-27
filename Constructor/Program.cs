using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        class A
        {
            public A ()
            {
                Console.WriteLine("A");
            }
            public A (int x)
            {
                Console.WriteLine("a");
            }
        }
        class B:A
        {
            public B()
            {
                Console.WriteLine("B");
            }
             public B (int x) : base (x)
            {
                Console.WriteLine("b");
            }
        }
        class C : B
        {
            public C ()
            {
                Console.WriteLine("C");
            }
             public C (int x) : base(x)
            {
                Console.WriteLine("c");
            }
        }
        static void Main(string[] args)
        {
            A x = new C();
            A y = new C(5);
            Console.ReadLine();
        }
    }
}
