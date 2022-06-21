using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Patterns
{
    class Patt1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coloumn Number");
            int COLOUMN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter row Number");
            int ROW = Convert.ToInt32(Console.ReadLine());
            for (int g=1;g<=COLOUMN;g++)
            {
                for(int h=1;h<=ROW;h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
