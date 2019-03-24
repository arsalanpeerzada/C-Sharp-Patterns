using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    numbers[i] = Convert.ToInt16(Console.ReadLine());
            //}
            //Array.Sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine(); 


            
            //int[] A = new int[10];
            //int i;
            //for (int i = 0; i < 9; i++)
            //{
                
            //    A[i] = Convert.ToInt32(Console.ReadLine());

            //}


            // sum of integers
            //int[] myarray = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    myarray[i] = Convert.ToInt16(Console.ReadLine());
            //}
            //int a = 0;
            //for (int j = 0; j < 10; j++)
            //{
            //    a = a + myarray[j];
            //}
            //Console.WriteLine(a);
            //Console.ReadLine();


            // 
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i); 
            }
            Console.ReadLine(); 














            Console.ReadKey();
        }





        
    }

}
