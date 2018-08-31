using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CopyingArray
    {
        static void Main()
        {
            // first way of copying an array
            int[] i = new int[] { 1, 2, 3, 4, 5 };
            int[] j = new int[i.Length];
            i.CopyTo(j, 0);
            Console.WriteLine("First way ");
            for (int k = 0; k < j.Length; k++)
            {
                Console.WriteLine(j[k]);
            }

            // way of copying an array 
            int[] L = i;
            Console.WriteLine("second way ");
            for(int k  = 0; k < L.Length; k++)
            {
                Console.WriteLine(L[k]);
            }
            // third way 

            int[] IntArray = new int[] { 1, 2, 3, 4 };
            int[] IntArrays = new int[IntArray.Length];
            for(int k =0; k < IntArrays.Length; k++)
            {
                IntArrays[k] = IntArray[k]; 
            }
            Console.WriteLine("third way");
            // for reading the elements from the IntArrays
            for(int k = 0; k < IntArrays.Length; k++)
            {
                Console.WriteLine(IntArrays[k]);
            }

            // fourth way 
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            int[] number = new int[num.Length];
            Array.Copy(num, number, number.Length);

            Console.WriteLine("fourth way");
            foreach(int k in number)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
    }
}
