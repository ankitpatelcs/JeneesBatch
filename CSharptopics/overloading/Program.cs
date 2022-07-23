using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Shape
    {
        internal void area(int r)
        {
            Console.WriteLine("Area of Circle: {0}",3.14*r*r);
        }
        internal void area(double r)
        {
            Console.WriteLine("Area of Square: {0}", r * r);
        }
        internal void area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle: {0}",l*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.area(10);
            s.area(10.5);
            s.area(20, 5);
            Console.Read();
        }
    }
}
