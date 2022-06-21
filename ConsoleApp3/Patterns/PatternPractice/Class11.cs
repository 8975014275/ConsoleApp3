using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class Class11
    {
        static void Main(string[] args)
        {
            /*
              1
              22
              333
             4444
             55555
            */
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                //spaces
                for (int j = 1; j <=n-i; j++)
                {
                   
                        Console.Write(" ");
                    
                }
                for(int j=1;j<=i;j++)
                    Console.Write(i + " ");
               
            }
            Console.WriteLine();
        }
    }
}
