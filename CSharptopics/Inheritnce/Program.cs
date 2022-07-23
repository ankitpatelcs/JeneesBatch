using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritnce
{
    class Employee
    {
        int id;
        string name;

        protected void GetEmp()
        {
            id = 1;
            name = "Jenees";
        }
        protected void ShowEmp()
        {
            Console.WriteLine("ID: {0}",id);
            Console.WriteLine("Name: {0}",name);
        }
    }

    class Payroll : Employee
    {
        int salary;
        internal void Getdata()
        {
            GetEmp();
            salary = 25000;
        }

        internal void Showdata()
        {
            ShowEmp();
            Console.WriteLine("Salary: {0}",salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.Getdata();
            p.Showdata();

            Console.Read();
        }
    }
}
