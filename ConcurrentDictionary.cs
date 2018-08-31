using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program1
    {
        static ConcurrentDictionary<int, string> o = new ConcurrentDictionary<int, string>();
      
       static void Main(string[] args)
        {
            Console.WriteLine("enter the key");
            var i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value");
            var j = Console.ReadLine();
            Thread o1 = new Thread(M1);
            Thread o2 = new Thread(M2);
            o1.Start();
            o2.Start();
            Console.ReadLine();

        }
        static void M1()
        {
            for (var i = 0; i < 10; i++)
            {
                o.TryAdd(i,"M1 added" + i);
            }
        }
        static void M2()
        {
            for(var j = 0; j < 10; j++)
            {
                o.TryAdd(j, "M2 added" + j);
            }
        }
    }
}
