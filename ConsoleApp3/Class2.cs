using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class swapini3
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping num1 ={0} num2 ={1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping num1 ={0} num2 ={1}", num1, num2);
            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine("before swapping num1 ={0} num2 ={1}",num1,num2);
            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;
            //Console.WriteLine("after swapping num1 ={0} num2={1}", num1,num2);

        }
    }
    class OWER
    {
        static void Main(string[] args)
        {
            int res, expo, b;
            b = Convert.ToInt32(Console.ReadLine());

            expo = Convert.ToInt32(Console.ReadLine());
            res = 1;
            for (int i = 1; i <= expo; i++)
            {
                res = res * b;
            }
            Console.WriteLine(res);
        }
    }
    class p
    {
        static void Main(string[] args)
        {
            int result, idx, a;
            a = Convert.ToInt32(Console.ReadLine());
            idx = Convert.ToInt32(Console.ReadLine());
            result = 1;
            for (int i = 1; i <= idx; i++)
            {
                result = result * a;
            }
            Console.WriteLine(result);
        }
    }
    class Power1
    {
        static void Main(string[] args)
        {
            int output, temp;
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int b = Convert.ToInt32(Console.ReadLine());

            output = 1;
            temp = 1;
            while (temp <= b)
            {
                output = output * a;
                temp++;
            }
            Console.WriteLine(output);
            Console.ReadLine();
            /*for(int i=1;i<=idx;i++)
            {
                result = result * b;
            }
            Console.WriteLine(result);*/
        }
    }
    class eec
    {
        static void Main(string[] args)
        {
            int i;
            for ( i = 2; i <= 20; i = i + 2) 
            {
                Console.WriteLine(i);
            }


            //}
            //static void Main(string[] args)
            //{

            //  for(int i=1;i<=5;i++)
            //  {
            //        if (i == 3)
            //            break;


            //  }
            //    Console.WriteLine(i);
            //}
        }



    }
}
