using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Point1
    {
        public double x, y;
        public Point1(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Triangle
    {
        public Point1 a, b, c;
        public double getArea()
        {
            double ncv,c1,c2,c3;
            c1 = Math.Sqrt((a.y - b.y) * (a.y - b.y) + (a.x - b.x) * (a.x - b.x));
            c2 = Math.Sqrt((b.y - c.y) * (b.y - c.y) + (b.x - c.x) * (b.x - c.x));
            c3 = Math.Sqrt((a.y - c.y) * (a.y - c.y) + (a.x - c.x) * (a.x - c.x));
            ncv = (c1 + c2 + c3)/2;
            return Math.Sqrt(ncv*(ncv-c1)*(ncv-c2)*(ncv-c3));
        }
    }
}
