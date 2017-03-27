using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcess
{
    class Program
    {
        #region
        public class A
        {
            public A()
            {
                Console.WriteLine("A");
            }
        }
        public class B : A
        {
            public B()
            {
                Console.WriteLine("B");
            }
            public void show()
            {
                Console.WriteLine("inRa");
            }
        }
        public class C : B
        {
            A obj = new A();
            A x = new B();
            public C()
            {
                A obj = new B();
                A x = new A();
                Console.WriteLine("C");
            }

        }
        #endregion
        #region
        public static String GetXauChuan(String x)
        {
            while (x.LastIndexOf("  ") > 0)
            {
                x = x.Replace("  ", " ");
            }
            if (x[0] == ' ')
            {
                x = x.Substring(1, x.Length - 1);
            }
            if (x[x.Length - 1] == ' ')
            {
                x = x.Substring(0, x.Length - 1);
            }
            return x;
        }
        public static String html(String x)
        {
            x = GetXauChuan(x);
            //thay the '>_' thanh '>'
            while (x.LastIndexOf("> ") > 0)
            {
                x = x.Replace("> ", ">");
            }
            //thay the '_<' thanh '<'
            while (x.LastIndexOf(" <") > 0)
            {
                x = x.Replace(" <", "<");
            }
            //thay the '<_' thanh '<'
            while (x.LastIndexOf("< ") > 0)
            {
                x = x.Replace("< ", "<");
            }
            //thay the '_>' thanh '>'
            while (x.LastIndexOf(" >") > 0)
            {
                x = x.Replace(" >", ">");
            }
            //thay the '>_<' thanh '><'
            while (x.LastIndexOf("> <") > 0)
            {
                x = x.Replace("> <", "><");
            }
            //thay the '/_>' thanh '/>'
            while (x.LastIndexOf("/ >") > 0)
            {
                x = x.Replace("/ >", "/>");
            }
            //thay the '_/' thanh '/'
            while (x.LastIndexOf(" /") > 0)
            {
                x = x.Replace(" /", "/");
            }
            //thay the '/ ' thanh '/'
            while (x.LastIndexOf("/ ") > 0)
            {
                x = x.Replace("/ ", "/");
            }
            return x;
        }
        #endregion
        #region
        public static char getSymborFromNumber(int number, int bias)
        {
            return ' ';
        }
        public static String getStringFromNumber(int number, int bias)
        {

            String str = null;

            return str;
        }
        #endregion
        #region
        public string NgatXau(String x)
        {
            x = html(x);
            return "";
        }
        #endregion
        static void Main(string[] args)
        {
            //Bai1
            C c = new C();
            //Bai2
            Console.Write("FlagA");
            String x = "  My name  is Dinh   Huy     Hung   ";
            x = GetXauChuan(x);
            Console.Write(x);
            Console.WriteLine("FlagB");
            //Bai3
            String result = "<html  >   <  body  >   this is  a test of string  <br / >  a  <   p > page   < /p>  </body>< / html>";
            result = html(result);
            Console.Write(result);
            //Bai4
            Console.ReadLine();
        }
    }
}
