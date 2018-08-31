using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace ConsoleApp2
{
    class FileThirdExample
    {
        static void Main()
        {
            /*string File = @"F:\myC#.net_Progrmas\MyDoc4.txt";

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] Lines = {"FirstLine","SecondLine","ThirdLines"};
            System.IO.File.WriteAllLines(@"F:\myC#.net_Progrmas\MyDoc4.txt", Lines);
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().

            //2 ND Way

            string text = "A class is the most powerful data type in C#. Like a structure," +
                        "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(@"F:\myC#.net_Progrmas\MyDoc4.txt", text);
            // Print the data from the text file
            string Display;
            foreach(File F in File)
            {
               if (!Lines.Contains("Hello"))
                {

                }
            }
            */

            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);

        }
    }

}


 
