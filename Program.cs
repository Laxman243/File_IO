using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program 
    {
        void Add(int a , int b , int c = 20)
        {
            int Total = a+b+c;
            Console.WriteLine(Total);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(10,20 , c : 100);
            Console.ReadKey();

        }
    }
}
