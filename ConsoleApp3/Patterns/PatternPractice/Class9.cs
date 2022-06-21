using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns.PatternPractice
{
    class Triangle01
    {
        static void Main(string[] args)
        {
            /*
             
             1
             0 1
             1 0 1
             0 1 0 1
             1 0 1 0 1

            */
            int n = 5;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    int sum = i + j;
                    if(sum%2==0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
