using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionss
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 90;
                int b = 0;
                int c = a / b;

                throw new OverflowException("custom exception message");
                Console.WriteLine("kjhgfghjkg");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured: ");
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
