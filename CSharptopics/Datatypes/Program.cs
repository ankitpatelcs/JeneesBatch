using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte: {0} to {1}",Byte.MinValue,Byte.MaxValue);
            Console.WriteLine("SByte: {0} to {1}",SByte.MinValue,SByte.MaxValue);
            Console.WriteLine("Int16: {0} to {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("short: {0} to {1}",short.MinValue,short.MaxValue);

            Console.WriteLine("Int32: {0} to {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("int: {0} to {1}", int.MinValue, int.MaxValue);

            Console.WriteLine("Int64: {0} to {1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("long: {0} to {1}", long.MinValue, long.MaxValue);

            Console.WriteLine("Double: {0} to {1}", Double.MinValue, Double.MaxValue);
            Console.WriteLine("float: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Decimal: {0} to {1}", Decimal.MinValue, Decimal.MaxValue);

            Console.Read();
        }
    }
}
