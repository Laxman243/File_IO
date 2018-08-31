using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // provide using System.IO ==> first 

namespace ConsoleApp2
{
    class FileFirstExample
    {
        static void Main()
        {
            // create the file using static Method Called Create
            File.Create(@"F:\myC#.net_Progrmas\mydoc.txt");

            File.WriteAllText(@"F:\myC#.net_Progrmas\mydoc.txt", "Helloywg  World");

            string Lines;
            Lines = File.ReadAllText(@"F:\myC#.net_Progrmas\mydoc.txt");
            Console.WriteLine(Lines);
 
            Console.Read();
        }
    }
}
