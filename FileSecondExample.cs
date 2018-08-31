using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApp2
{
    class FileSecondExample
    {
        static void Main(string[] args)
        {
            
            string FileName = @"F:\myC#.net_Progrmas\mydoc2.txt";
            
            WriteFile(FileName);
            ReadFile(FileName);
            Console.Read();
        }
        //write into file 
        static void WriteFile(string FileName)
        {
            File.WriteAllText(FileName, "hello world");
        }

        static void ReadFile(string FileName)
        {
            Console.WriteLine(File.ReadAllText(FileName));
        }

    }
}
