using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class FloydsTriangle
    {
        static void Main(string[] args)
        {
          /*
             1
             2 3
             4 5 6
             7 8 9 10
             11 12 13 14 15
         */
            int n = 5;
            int num = 1;
            for(int i=1; i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(num+" ");
                    num++;
                }
                Console.WriteLine();

            }
        }
    }
}
