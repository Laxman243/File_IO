using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Sample
    {
        int Add();
        void Sub(int i, int j);
    }
    class InterfaceExample: Sample
    {
        static void Main()
        {
            Console.WriteLine("enter the first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int j = Convert.ToInt32(Console.ReadLine());
            InterfaceExample obj = new InterfaceExample();
            obj.Add();
            obj.Sub(i,j);
            Console.ReadKey();
        }
        public int Add()
        {
            return 4;
        }
        public void Sub(int i, int j)
        {
            Console.WriteLine(i + j);
        }
    }
}
