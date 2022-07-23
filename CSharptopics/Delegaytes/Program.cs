using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaytes
{
    public delegate void delegate_1();
    public delegate string delegate_2(int id,string name);
    class myDelegate
    {
        internal void show()
        {
            Console.WriteLine("calling show function");
        }
        internal void display()
        {
            Console.WriteLine("calling display function");
        }

        internal string Showdata(int id,string name)
        {
            return $"Employeeid: {id}, First name: {name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate m = new myDelegate();
            delegate_1 del1 = new delegate_1(m.display);
            //multicasting
            del1 += new delegate_1(m.show);

            del1.Invoke();

            del1 -= new delegate_1(m.show);
            del1.Invoke();

            delegate_2 del2 = new delegate_2(m.Showdata);
            string data = del2.Invoke(23,"Yash");
            Console.WriteLine(data);

            Console.Read();
        }
    }
}
