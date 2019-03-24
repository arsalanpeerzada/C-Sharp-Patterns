using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result;
                result= num * i;
                Console.WriteLine("{0} x {1} = {2}" , num , i , result);

            }

            Console.ReadLine();
      
        }
    }
}
