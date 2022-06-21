using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class PatternP
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 7; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (c == 0 || c == r || r+c == 4 )
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
