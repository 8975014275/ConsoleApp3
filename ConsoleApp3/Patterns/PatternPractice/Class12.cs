using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class Class12
    {
        /*
         
           *
          ***
         *****
        *******
        *******
         *****
          ***
           *
           
        */
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                //spaces
                for (int j = 1; j <= n - i; j++)
                

                    Console.Write(" ");

                
                for (int j = 1; j <=2*i-1; j++)
                    Console.Write("*");

            }
            Console.WriteLine();
            for (int i = n; i <= 1; i--)
            {
                //spaces
                for (int j = 1; j <= n - i; j++)
                

                    Console.Write(" ");

                
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

            }
            Console.WriteLine();


        }
    }
}
