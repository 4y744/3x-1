using System;
using System.Collections.Generic;

namespace _3x_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Conjecture();

            Console.ReadKey();
        }

        static void Conjecture()
        {
            Console.WriteLine("Simulate until the number: ");
            int x;
            int y;
            int Count = 0;
            string yInput = Console.ReadLine();
            bool yParse = int.TryParse(yInput, out y);

            if (yParse)
            {
                for (int i = 1; i < Math.Abs(y) + 1; i++)
                {
                    Console.WriteLine("Try with the number {0}:", i);
                    x = i;
                    while (x != 1)
                    {
                        if (x % 2 == 0)
                        {
                            x = x / 2;
                        }
                        else
                        {
                            x = 3 * x + 1;
                        }
                        Count++;
                        Console.WriteLine("Try {0}: x = {1}", Count, x);
                    }
                    Console.WriteLine("It took the number {0} {1} tries", i, Count);
                    Console.WriteLine();
                    Count = 0;
                }
            }
        }
        

    }
}
