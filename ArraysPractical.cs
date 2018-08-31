using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArraysPractical
    {
        static void Main()
        {
            //Array declaration  
            int[] Array = new int[3];
            //Array initialization
            Array[0] = 100;
            Array[1] = 101;
            Array[2] = 102;

            //reading array elements through simple for loop 
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("value of Array is : "+ Array[i]);
            }

            // reading elements through advanced for loop i.e foreach loop
            foreach (int j in Array)
            {
                Console.WriteLine("From ForEachLoop: " + j);
            }
            Console.ReadLine();
        }
    }
    class ArraySample
    {
        static void Main()
        {
            int[] array = {1,3,4,5,6};
            Console.WriteLine(array.Length); //Length "property" will show the length of an array 

            /* string[] Names;     Once you declare an array without new Keyword then, the array should be initialized
             Names[0] = "laxman";    there itself, otherwise you will get error.
             */

            //Another way of initializing an array 
            string[] Employees = new string[] { "laxman", "harsh", "mahi", "bhaskar", "soro","pari"};
            Console.WriteLine(Employees.Length);
            //read array elements
            foreach(string i in Employees)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
    //TWO DIMENSIONAL ARRAY
    class TwoDimensionalArray
    {
        static void Main()
        {
            int[,] Elements = new int[3, 2] { { 0, 4 }, { 1, 2 }, { 2, 4 } };
            int i, j;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Elements[{0},{1}] = {2},",i, j, Elements[i,j]);
                  
                }
            }
            Console.ReadLine();
        }
    }
    //THREE DIMENSIONAL ARRAY
    class ThreeDimensionlaArray
    {
        static void Main()
        {
            int[,,] Records = new int[2, 3, 3] { { { 1, 1, 1 }, { 2, 2, 2} ,{ 3,3,3} },{ { 4, 4, 4 }, { 5, 5, 5} ,{ 6, 6, 6 } } };
            int i;
            int j;
            int k;

            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 3; j++)
                {
                   
                    for(k = 0; k < 3; k++)
                    {
                        Console.WriteLine("Records[{0},{1},{2}] = {3},", i, j,k,Records[i, j,k]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
    class JaggedArray
    {
        static void Main()
        {   //declaration
            string[][] jaggedArray = new string[3][];

            // create three string arrays 
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[2];
            jaggedArray[2] = new string[4];

            //initialization // [0] index of array got filled with three values
            jaggedArray[0][0] = "Java";
            jaggedArray[0][1] = "html";
            jaggedArray[0][2] = "css";

            // initialization of [1] index array
            jaggedArray[1][0] = "Angular";
            jaggedArray[1][1] = "C#";

            //initialization of [2] index array
            jaggedArray[2][0] = ".net";
            jaggedArray[2][1] = "ADO.net";
            jaggedArray[2][2] = "Ajax";
            jaggedArray[2][3] = "Jquery";

            // print the jaggedArray elements
            //outerloop to get ang string array and read its values in innerloop
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine("skills");
                Console.WriteLine("================");

                // inner loop for reading value
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine( innerArray[j]);
                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();
        }
    }
}
