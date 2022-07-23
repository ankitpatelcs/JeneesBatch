using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 5, 7, 9 };
            arr[1] = new int[] { 1, 3, 7, 8 };
            arr[2] = new int[] { 4, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" "+arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
