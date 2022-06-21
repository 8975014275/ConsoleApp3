using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class Right180dHalfPyramid
    {
        static void Main(string[] args)
        {
            /*
             
                 *
                **
               ***
              ****
              
              */

            int r = 4;

            for (int i = 1; i <= r; i++)
            {
                for (int space = 1; space <= r - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
