using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class PatternH
    {
        static void Main(string[] args)
        {
            for(int r = 1;r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || c == 5 || r == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");    
                }
                Console.WriteLine();
                
            }
                  
        }
    }
}
