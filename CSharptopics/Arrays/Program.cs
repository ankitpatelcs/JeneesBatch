using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            string name = "";
            Console.WriteLine("Enter Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] : {1}", i, arr[i]);
            }
            Console.Read();
        }
    }
}
