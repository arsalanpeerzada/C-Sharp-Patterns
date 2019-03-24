using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2d_ar2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //prime numbers 

            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            string Result = "prime";

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    Result = "not prime";
                break;
            }
        }
            Console.WriteLine(Result);




            Console.ReadKey();

        }
    }
}
