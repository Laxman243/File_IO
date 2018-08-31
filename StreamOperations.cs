using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{

    //STREAM WRITER EXAMPLE CLASS
    class StreamOperations
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\myC#.net_Progrmas\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            // YOU CAN WRITE INTO THE FILE BY LIKE THIS -->

            s.WriteLine("hello c#");
            s.WriteLine("welcome to txt file");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
            Console.Read();
        }
    }
    //STREAM READER EXAMPLE 
    public class StreamReaderExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\myC#.net_Progrmas\\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);
            Console.WriteLine(line);
            Console.Read();
            s.Close();
            f.Close();
        }
    }
}
