using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace ConsoleApp2
{
    class StreamClass
    {
        static void Writer(string FileName)
        {
            // create filestream for writing into the file and provide the file access ,your opeation is depend on based on the file access
            FileStream Fs = new FileStream(FileName, FileMode.Create,FileAccess.Write);

            // provide a if condition ,
           if( Fs.CanWrite)
            {
                // create a byte[] array which stires the ASCII values of your data which. it stores your data in ASCII form
                // ASCII helps in retrieving data fast
                byte[] buffer = Encoding.ASCII.GetBytes("Hello world");
                //finally apply write method on butter and specify the location, starting point of file and the length 
                // how long data it should store
                Fs.Write(buffer,0,buffer.Length);
            }
           // after writing into the file , first and formost work is to flush the file 
            Fs.Flush();
            //then after flushing the file , second close the file
            Fs.Close();
        }
        static void Reader(string FileName)
        {
            // reading from the file also similar to writing 
            //create a fileStream and provides the file access , 
            FileStream Fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            if(Fs.CanRead)
            {
                // declare an byte[] array with its size 
                byte[] buffer = new byte[1024];
                // create an interger to stores the byte[] values into it 
                int byteStream = Fs.Read(buffer, 0, buffer.Length);

                // finally print the information which stored into the file
                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, byteStream));
            }
            Fs.Close();
        }
        static void Main()
        {
            string FileName = @"F:\myC#.net_Progrmas\laxman.txt";
            Writer(FileName);
            Reader(FileName);
            Console.Read();
        }
    }
}
