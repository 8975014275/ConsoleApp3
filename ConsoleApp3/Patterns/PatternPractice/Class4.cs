using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class HalfPyramidUlta
    {
        static void Main(string[] args)
        {
            /*
             
              ****
              ***
              **
              *
              
              */
            // Console.WriteLine("ENTER THE ROWS");
            // int r = Convert.ToInt32(Console.ReadLine());
            int r = 4;

            for (int i = r; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}
