using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class PatternK
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (c == 0 || r == 1 || r == (3-c) || r == (3+c))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
