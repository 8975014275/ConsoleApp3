using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class loopdemo
    {
        static void Main(string[] args)
        {
            int i;
            ////for (i = 1; i <= 5; i++)
            ////{
            ////    Console.WriteLine("hello");
            ////}

            //for (i =1; i<=5;i++)
            //{
            //    Console.WriteLine(i);
            ////}
            //for (i =35;i<=75;i++)
            //    Console.WriteLine(i);
            //for (i =185; i>=85;i--)
            //{
            //    Console.WriteLine(i);
            //}
            for (i = 2; i <= 10; i = +2)

            {
                Console.WriteLine(i);
            }


        }
    }
    class sumofloop
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for (i = 1; i <= 10; i++)
                sum = sum + i;
            Console.WriteLine(sum);
        }
    }
    class factirialloo
    {
        static void Main(string[] args)
        {
            //int i, fact = 1;
            //for ( i = 1; i <= 5; i++) ;
            //{
            //    fact = fact * i;
            //    Console.WriteLine(fact);
            //}
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
               
            }
            Console.WriteLine(fact);


        }
    }
    class fctrl
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("factorial=" + factorial);
        }
    }
    class Even
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

        }
    }
    class odd
    {
        static void Main(string[] args)
        {
            //int limit;
            ////Console.WriteLine("enter the num");
            //limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 25; i <= 45; i++)
            {
                if (i % 2 != 0)


                    Console.WriteLine(i);

            }
        }
    }
    class oddc
    {


        static void Main(string[] args)
        {
            int c = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    c++;
                }

            }




            Console.WriteLine("counter =" + c);



        }
    }
    //class magicnumber
    //{
    //    static void Main(string[] args)
    //    {
    //        int magic number =
    //    }
    //}

    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            //a=153
            //three digit numb
            int x = a;
            int sum = 0;
            while (a > 0)
            {
                int digit = a % 10;
                sum = sum + digit * digit * digit;
                a = a / 10;

            }
            if (sum == x)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("not AS");
        }
    }
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int input = Convert.ToInt32(Console.ReadLine());
            int digit, sum = 0, product = 1;

            while (input > 0)
            {
                digit = input % 10;

                // getting the sum
                // of digits
                sum = sum + digit;
                product = product * digit;
                input = input / 10;
            }

            // Comparing the sum
            // and product
            if (sum == product)
                Console.WriteLine("The number is " +
                                    "a Spy number");
            else
                Console.WriteLine("The number is " +
                                "NOT a Spy number");
        }



    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = a;
            int rev = 0;
            while (a > 0)
            {
                int d = a % 10;
                rev = rev * 10;
                a = a / 10;

            }
            if (rev == n)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }



    }

    class seris1
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write("How many terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
                int c = a + b;

                a = b;
                b = c;

            }
            Console.Write(a + " ");
        }
    }
    class prm
    {
        static void Main(string[] args)
        {
                Console.WriteLine("How many terms");
                int terms1 = Convert.ToInt32(Console.ReadLine());
                int sum1 = 1;
                for (int i = 1; i <= terms1; i++)
                {
                    sum1 = i * i + 1;
                    Console.Write(sum1 + ",");
                }
                //2,5,10,17,26,37,50,65,82,101,
        }
    }
    class sr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum1 = 1;
            for (int i =1;i<=terms;i++)
            {
                sum1 = (i * i) + (i * i * i);
                Console.Write(sum1 + ",");
            }
        }
    }

        //
    class series3
    {
        static void Main(string[] args)
        {
                int a = 0, b = 1, c = 0;
                Console.Write("{0} {1}", a, b);
                for (int i = 2; i <= 9; i++)
                {
                    c = a + b;
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                    //0 1 1 2 3 5 8 13 21 34
                }
        }
    }
    
    class series31same
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write("How many terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
                int c = a + b;
                Console.Write(a + " ");
                a = b;
                b = c;
                //0 1 1 2 3 5 8 13 21 34
            }

        }         
    }
    class fctr2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1; int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
                sum = factorial;
            }
            Console.WriteLine("factorial=" + sum);
        }
    }


}




