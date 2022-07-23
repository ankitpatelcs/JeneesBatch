using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharptopics
{
    class Program
    {
        static void Main(string[] args)
        {
            int id ;
            string name ;

            Console.Write("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name`: ");
            name=Console.ReadLine();

            //Console.Write("ID: {0}\nName: {1}",id,name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);

            Console.Read();
        }
    }
}
