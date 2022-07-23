using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    class MyClass<Type1,Type2>
    {
        Type1 id;
        Type2 name;

        public MyClass(Type1 i, Type2 n)
        {
            id = i;
            name = n;
        }

        internal void display()
        {
            Console.WriteLine("Value 1: {0}",id);
            Console.WriteLine("Value 2: {0}",name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, string> m1 = new MyClass<int, string>(10,"Piyush");
            m1.display();

            MyClass<string, DateTime> m2 = new MyClass<string, DateTime>("Parth",DateTime.Now);
            m2.display();

            Console.Read();
        }
    }
}
