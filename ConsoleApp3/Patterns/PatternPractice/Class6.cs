using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class HalfPyramid1to5
    {
        /*
             
              1
              12
              123
              1234
              12345
              
              */
        static void Main(string[] args)
        {
            // Console.WriteLine("ENTER THE ROWS");
            //int r = Convert.ToInt32(Console.ReadLine());
           // int r = 5;

            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();


            }
        }
    }
}
