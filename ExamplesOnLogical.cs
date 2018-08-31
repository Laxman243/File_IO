using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
namespace ConsoleApp2
{
    public class FileReadingExample
    {
        public static void Main(string[] args)
        {
            string path = File.ReadAllText("F:\\myC#.net_Progrmas\\TestFile.txt", Encoding.UTF8);
            FileStream f = new FileStream("F:\\myC#.net_Progrmas\\TestFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader s = new StreamReader(f);
          
            int counter = 0;
            string delim = " ,."; 
            string[] fields = null;
            string line = null;
            int characterCount = 0;
            var lineCount = 0;
            int specialChar = 0;

            // COUNTING WORD / Line / 
            while (!s.EndOfStream)
            {
                line = s.ReadLine();//each time you read a line you should split it into the words
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length; //and just add how many of them there is
                if (s != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        characterCount++;
                    }
                }
                lineCount++;
            }
            //COUNT SPECIAL CHARACTER
            for(int i = 0; i <= path.Length; i++)
            {
                if( i == '!' || i == '@' || i == '#' || i == '$' || i == '%' || i == '^' || i == '&' || i == '*' ||  i == '(' || i == ')' || i == '?' || i == '>' || i == '<' || i == '/' || i == '{' || i == '}' ||
                  i == '[' || i == ']' || i == '~' || i == ';' || i == ':' || i == '+' || i == '=' || i == '.')
                {
                    specialChar++;
                }
            }
            s.Close();
            Console.WriteLine("Character available in file : "+ characterCount);
            Console.WriteLine("totals lines : " + lineCount);
            Console.WriteLine("specialcharacter is : {0} ", specialChar);
            Console.WriteLine("The total word count is : {0} ", counter);         
            Console.Read();
        }
    }    
}
