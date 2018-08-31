using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Sample1
    {
        abstract public void Addition();
        public virtual void Add()
        {
            Console.WriteLine("welcome to Abstract class");
        }
    }
       
    class AbstractExample : Sample1
    {
       
        public override void Addition()
        {
            Console.WriteLine("Addition of two number is :");
        }
      
        public static void Main()
        {
            Console.WriteLine("enter the firsr number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int j = Convert.ToInt32(Console.ReadLine());
            AbstractExample obj = new AbstractExample();
            obj.Addition();
            obj.Add();
            Console.ReadKey();

        }
    }
}
