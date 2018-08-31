using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class FileLogical
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("F:\\myC#.net_Progrmas\\TestFile.txt"))
            {
                writer.WriteLine("C# File Ht");
            }
            Console.WriteLine("Data written successfully...");
            Console.Read();
        }
    }
    class FileLogicalRead
    {
        static void Main()
        {
            using (TextReader tr = File.OpenText("F:\\myC#.net_Progrmas\\TestFile.txt"))
            {
                Console.Write(tr.Peek());
            }
            Console.Read();
            Console.Read();
            Console.Read();
        }
    }
}
