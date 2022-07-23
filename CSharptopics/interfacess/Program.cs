using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacess
{
    interface IEmployee
    {
        void getdata();
        void showdata();
        void display();
    }
    class Employee : IEmployee
    {
        public void display()
        {
            Console.WriteLine();
        }

        public void getdata()
        {
            
        }

        public void showdata()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee e = new Employee();
            e.display();
        }
    }
}
