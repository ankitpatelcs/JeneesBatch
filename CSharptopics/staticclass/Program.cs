using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclass
{
    sealed class MyClass2
    {

    }
    class MyClass3:MyClass2
    {

    }
    static class MyClass
    {
        static public int a=90;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.a = 50;

        }
    }
}
