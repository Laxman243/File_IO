using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace ConsoleApp2
{
    class TextWriterExamples
    {
            static void Main(string[] args)
            {
                using (TextWriter writer = File.CreateText("F:\\myC#.net_Progrmas\\f.txt"))
                {
                    writer.WriteLine("Hello C#");
                    writer.WriteLine("C# File Handling by JavaTpoint");
                }
                Console.WriteLine("Data written successfully...");
            }
        }
    class TextReaderExample
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("F:\\myC#.net_Progrmas\\f.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
               //Console.WriteLine(tr.Read());
                //Console.WriteLine(tr.ReadLine());
            }
            Console.Read();
        }
    }
}

