using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            if (a>5)
            {
                Console.WriteLine("a is greater");
            }
            else if(a<5)
            {
                Console.WriteLine("a is lessor");
            }
            else if(a==5)
            {
                Console.WriteLine("a is equal");
            }

            Console.Read();
        }
    }
}
