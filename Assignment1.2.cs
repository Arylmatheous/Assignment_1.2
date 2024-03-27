using System;


    class Assignment1_2
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            while (num1 <= 100)
            {
                if (num1 % 3 == 0 && num1 % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (num1 % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (num1 % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine(num1);
                }
                num1++;

            }
        }
    }


