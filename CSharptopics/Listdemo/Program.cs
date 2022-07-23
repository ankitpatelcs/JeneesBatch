using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            //li.Add(25);
            //li.Add(46);
            //li.Add(29);
            //li.Add(73);
            //li.Add(38);
            Console.WriteLine("Enter List: ");
            char ch;
            do
            {
                li.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Do you want ti add more? (y/n): ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch=='y');

            Console.WriteLine("List: ");
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
