using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    class Employee
    {
        public int empid;
        public string name;


    }
    class Payroll : Employee
    {
        public int salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll e = new Payroll();
            e.empid = 1;
            e.name = "Chandan";
            e.salary = 25000;

            Console.WriteLine("ID: " + e.empid);
            Console.WriteLine("Name: " + e.name);
            Console.WriteLine("Salary: " + e.salary);

            Console.Read();
        }
    }
}
