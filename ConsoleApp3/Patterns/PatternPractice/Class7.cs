using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class HalfPyramid1to5Ulta
    {
        /*

             12345
             1234
             123
             12
             1

             */
        static void Main(string[] args)
        {
             int r = 5;

             for (int i = r; i >= 1; i--)
             {

                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j);
                 }
                 Console.WriteLine();


             }
          /*  int r = 5;

            for (int i = 1; i <= r; i++)
            {

                for (int j = 1; j <=r-i+1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();


            }*/
        }
    }
}
