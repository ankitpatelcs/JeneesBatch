using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object s = a;   //boxing

            string num = "25";
            int b = Convert.ToInt32(num);
        }
    }
}
