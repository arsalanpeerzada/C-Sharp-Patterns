
            //paste this code in main function !
            Console.WriteLine("Enter number to build a diamond");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //reverse it

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();