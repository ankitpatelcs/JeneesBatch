using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiess
{
    class MyClass
    {
        int id=25;
        
        public MyClass()
        {
            id = 25;
            
        }
        public int empid
        {
            get
            {
                return id;
            }
            //set
            //{
            //    id = value;
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            //m.empid = 45;

            Console.WriteLine(m.empid);

            Console.Read();
        }
    }
}
