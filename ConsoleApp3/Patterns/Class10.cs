using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class Class10
    {
        /*
            1
           22
          333
         4444
        55555

        */
        static void Main(string[] args)
        {
            int k = 4;
            for (int i = 1; i <= 5; i++)
            { 
                for (int space=1;space<=k;space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                k--;

            }
        }
    }
    
}
