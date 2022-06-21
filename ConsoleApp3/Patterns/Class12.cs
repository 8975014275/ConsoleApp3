using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE ROWS");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int space = 1; space <= r-1; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                

            }
        }
    }
}
