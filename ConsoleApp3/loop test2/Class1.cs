using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.loop_test2
{
    class prob1
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=100;i++)
                if(i%5!=0 && i%10!=0)
                {
                    Console.WriteLine(i);
                }
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
    class Trimorphic
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int cube = n * n * n;
            int a = n;
            bool istrimorphic = true;
            while (n > 0)
            {
                int r1 = n % 10;
                n = n / 10;
                int r2 = cube % 10;
                cube = cube / 10;
                if (r1 != r2)
                {
                    istrimorphic = false;
                    break;
                }

            }
            if (istrimorphic == true)
                Console.WriteLine("trimorphic");
            else
                Console.WriteLine("not");
        }
    }
    class sr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum1 = 1;
            for (int i = 1; i <= terms; i++)
            {
                sum1 = (i * i) + (i * i * i);
                Console.Write(sum1 + ",");
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
    class evenprimesq
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            else
                    Console.WriteLine(i*i);
               
        }
    }
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            //a=153 = harshad niven numb
            //sum=2
            //divide  = harshad niven numb
            int sum = 0;
            int t = a;
            while (a > 0)
            {
                int d = a % 10;
                sum = sum + d;
                a = a / 10;
            }
            if (t % sum == 0)
                Console.WriteLine("Harshad Niven");
            else
                Console.WriteLine("Not HN");

        }
    }


    class b
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for( i =1;i<=10;i++)
            
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
   
}
