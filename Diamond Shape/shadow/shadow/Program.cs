﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shadow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            int numberOfSpaces = 0;
            int numberOfStars = numberOfLines + (numberOfLines - 1);

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(' ');
                }
                numberOfSpaces = numberOfSpaces + 1;

                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write('*');
                }
                numberOfStars = numberOfStars - 2;
                Console.WriteLine();
            }

            int numberOfSpaces1 = numberOfLines - 1;
            int numberOfStars1 = numberOfLines - numberOfSpaces1;

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfSpaces1; j++)
                {
                    Console.Write(' ');
                }
                numberOfSpaces1--;

                for (int k = 0; k < numberOfStars1; k++)
                {
                    Console.Write('*');
                }
                numberOfStars1 = numberOfStars1 + 2;
                Console.WriteLine();
            }
        }
    }
}
