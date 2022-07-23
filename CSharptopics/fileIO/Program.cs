using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class FileOperations
    {
        internal void WriteFile(string filename)
        {
            StreamWriter sw= File.CreateText(filename);
            Console.Write("Enter text: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("Write success.");
        }

        internal void ReadFile(string filename)
        {
            StreamReader sr= File.OpenText(filename);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("Read Success");
        }

        internal void AppendFile(string filename)
        {
            StreamWriter sw = File.AppendText(filename);
            Console.Write("Enter text to append: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("Write success.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileOperations fio = new FileOperations();
            string filename = @"C:\Ankit Patel\Yash.txt";
            fio.WriteFile(filename);
            fio.ReadFile(filename);

            fio.AppendFile(filename);
            fio.ReadFile(filename);

            Console.Read();
        }
    }
}
