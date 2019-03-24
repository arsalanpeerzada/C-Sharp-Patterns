using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Columns: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter Matrix({0},{1}): ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] b = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter Matrix({0},{1}): ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.ReadKey();
            }
        }
    }
}
