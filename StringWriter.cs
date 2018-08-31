using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace ConsoleApp2
{
    class StringWriter
    {
        private StringBuilder sb;

        public StringWriter(StringBuilder sb)
        {
            this.sb = sb;
        }

        static void Main()
        {
            string text = " Hello, Welcome to Bizruntime" + "\n today day is wednesday" + "\n thank you ";

            // creating StringBuilder instance
            StringBuilder sb = new StringBuilder(text);

            //passing string builder reference to string writer
            StringWriter sw = new StringWriter(sb);
            

            //
            StringReader sr = new StringReader(sb.ToString());
            //reading data
            while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.Read();
        }
    }
}
