using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    abstract class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("calling from employee");
        }
    }
    class Payroll:Employee
    {
        override public void display()
        {
            Console.WriteLine("calling from Payroll");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.display();

            Console.Read();
        }
    }
}
