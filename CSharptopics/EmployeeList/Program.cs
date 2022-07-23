using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1, fname="Jenees", email="j@gmail.com" });
            li.Add(new Employee { empid=2, fname="Parth", email="pt@gmail.com" });
            li.Add(new Employee { empid=3, fname="Piyush", email="p@gmail.com" });
            li.Add(new Employee { empid=4, fname="Yash", email="y@gmail.com" });

            foreach (var item in li)
            {
                Console.WriteLine();
                Console.WriteLine("Employee ID: {0}: ",item.empid);
                Console.WriteLine("Employee Name: {0}: ",item.fname);
                Console.WriteLine("Employee Email: {0}: ",item.email);
            }
            Console.Read();
        }

    }
}
