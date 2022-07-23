using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        int empid;
        string name;

        public Employee(int empid,string name)
        {
            this.empid = empid;
            this.name = name;
        }

        internal void GetData()
        {
            empid = 90;
            name = "Prakash";
        }
        internal void ShowData()
        {
            Console.WriteLine($"Employee ID: {empid}" );
            Console.WriteLine("Employee Name: " + name);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(15,"Yash");
            //e.GetData();
            e.ShowData();

            //
        }
    }
}
