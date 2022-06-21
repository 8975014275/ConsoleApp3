using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class pp11
    {
        static void Main(string[] args)
        {
            {
                /*
                     6
                    56
                   456
                  3456
                 23456
                123456
                */
                for (int i = 6; i >= 1; i--)
                {
                    for (int space = 1; space <i-1; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= 6; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                   
                }
            }
        }
    }
}   
