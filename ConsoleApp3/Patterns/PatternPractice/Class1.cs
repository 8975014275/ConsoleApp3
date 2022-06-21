using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class STARRECTANGLE
    {
        static void Main(string[] args)
        {
            /*
              *****
              *****
              *****
              *****
              */
            int c = 4;
            int r = 5;
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

}
