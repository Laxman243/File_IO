using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // GENERICS FUNCTION EXAMPLE
    class GenericsFunction
    {
        static void Display <L>(L s)
        {
            Console.WriteLine("value is :" + s);
              
        }
        static void Main()
        {
            Display("hello");
            Display(10);
            Console.ReadKey();
        }
    }
    // GENERICS CLASS EXAMPLE
    class GenericsExample <G>
    {
        public void Display<L>(L s)
        {
            Console.WriteLine(s);
        }
        
    }
    class GenericClass 
    {
        static void Main()
        {
            GenericsExample<string> obj = new GenericsExample<string>();
            obj.Display(100);
            obj.Display("hello");
            Console.ReadKey();
        }
    }
    // GENERICS CONSTRAINTS EXAMPLE
    class ClsGenerics<Anytype> where Anytype : class
    {
        public void Add<Anytype>( Anytype obj)
        {
            Console.WriteLine( obj);
        }
        static void Main(string[] args)
        {
            ClsGenerics<Anytype> obj = new ClsGenerics<Anytype>();
            obj.Add("hello");
            Console.ReadKey();
            
        }
    }
}
