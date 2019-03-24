using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///* local variable definition */
            //int i, j;

            //for (i = 1; i < 100; i++)
            //{
            //    for (j = 2; j <= (i / j); j++)
            //    {
            //        if ((i % j) == 0)
            //        {
            //            break;
            //        }
            //    }
            //    // if factor found, not prime
            //    if (j > (i / j))
            //    {
            //        Console.WriteLine("{0} is prime", i);
            //    }
            //}

            //int a = 8;
            //int b = 9;
            //int c = ++b;
            //int d = c++;
            //int e = a++;

            //Console.WriteLine(e++);
            //Console.WriteLine(++e);

            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;


                Console.WriteLine(b);

            }



           
        }
    }
}
