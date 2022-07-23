using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumdemo
{
    class Program
    {
        enum Weekdays
        {
            Sunday=1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine((int)Weekdays.Thursday);
            Console.Read();
        }
    }
}
