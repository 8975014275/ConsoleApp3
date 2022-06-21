using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Datatype12
    {
        static void Main(string[] args)
        {
            byte mybite1 = 30;//1 BYTE
            sbyte mybite2 = -78;
            Console.WriteLine(mybite1);
            Console.WriteLine(mybite2);

            short myshort1 = 300;// 2 BYTE
            short myshort2 = -708;
            Console.WriteLine(myshort1);
            Console.WriteLine(myshort2);

            int myint = 6798; // 4 BYTE
            int myint1 = -9875;
            Console.WriteLine(myint);
            Console.WriteLine(myint1);

            long mylong2 = -98564589663856L; //8 BYTE
            Console.WriteLine(mylong2);

            double D1 = 78.23;// 8 BYTE , AFTER DEC 15-16 DIG
            Console.WriteLine(D1);

            float MYF = 23.23f; //4 BYTE,AFTER DEC 15-16 DIG
            Console.WriteLine(MYF);


        }

    }
    class Sum12
    {
        static void Main(string[] args)
        {
            int num1, num2, addition;
            //Console.WriteLine("Enter two numbers");
            //  num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());

            num1 = 5;
            num2 = 7;
             addition = num1 + num2;
            Console.WriteLine("Addition of two numbers=" + addition);
        }
    }
    class sum13
    {
        static void Main(string[] args)
        {
            int length, breadth, area_of_rectrangle;
            length = 5;
            breadth = 7;
            area_of_rectrangle = length * breadth;
            Console.WriteLine("area_of_rectrangle ="+area_of_rectrangle);

            
        }
    }
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("enter the radius 0f cicle");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("area of circle is=" +area);
            
         
           

        }
    } 
    class demo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("number1 is greater");
            }
            else
                Console.WriteLine("number2 is greater");
        }
    }
    class program1
    {
        static void Main(string[] args)
        {
            int i = -10;
            for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i++));
            Console.ReadLine();
        }
    }
    class T1
    {
        static void Main(string[] args)
        {
            float f;
            for(f=0.1f;f<0.5;f+=1)
                Console.WriteLine(++f);
            Console.ReadLine();
        }
    }
    class ternaryoperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second the number");
            int num2 = int.Parse(Console.ReadLine());
            //if (num1>num2)
            //{
            //    Console.WriteLine(num1);
            //}
            //else
            //{
            //    Console.WriteLine(num2);
            //}
            string result = (num1 > num2) ? "num1 is gr" : "num2 is gr";
            Console.WriteLine(result);

        }
    }
    class ternaryoperator2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            string ans = num > 0 ? "positive" : num < 0 ? "negative" : "zero";
            Console.WriteLine("ans="+ans);
         



        }
    }
    class ternaryop3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder;
            remainder = num % 2;
            string result = remainder == 0 ? "even" : "odd";
            Console.WriteLine("ANS=" + result);



        }
    }
    class maxternaery
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd");
            int c = Convert.ToInt32(Console.ReadLine());
            /*if (a > b)
             {
                 if (a > c)
                 {
                     Console.WriteLine(a + " is max");
                 }
                 else
                     Console.WriteLine(c + "is max");
             }
             else if (b > c)
             {
                 Console.WriteLine(b + " is max");
             }
             else
                 Console.WriteLine(c + "is max");*/

            string st = a > b ? (b > c) ? "a is greater" : "b is greater" :
                b > c ? "b is greater" : "c is greater";
            Console.WriteLine(st);

        }
    }
    class fgh
    {
        static void Main(string[] args)
        {
            for(int i=1;i<100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }




}

