using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.loop_test_3
{
    class prob1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                if (i % 5 != 0 && i % 10 != 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
    class fact2
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
    class evenprimesq
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine(i * i);

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
    class abc1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("blue");
                }
                else
                    Console.WriteLine(i);

        }
    }
    public class KrishnamurthyNumber
    {
     
        public static bool IsKrishnamurthy(int number)
        {
            
            int sum = 0, lastDigit = 0;
            int tempNum = number;
            
            while (tempNum != 0)
            {
                lastDigit = tempNum % 10;
                sum += Convert.ToInt32(Factorial(lastDigit));
                tempNum /= 10;
            }

            
            if (sum == number)
                return true;
            return false;
        }
         
        public static long Factorial(int number)
        {
            long fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    
        public static void Main()
        {
            
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
         
            bool result = IsKrishnamurthy(number);
            if (result)
                Console.WriteLine(number + " Is a Krishnamurthy Number.");
            else
                Console.WriteLine(number + " Is not a Krishnamurthy Number.");
            Console.ReadLine();
        }
    }
    class Order2
    {
        private int order_id;
        private string cust_name;
        private string city;
        private string delivered;

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }

        }
        public string Delivered
        {
            get { return delivered; }
            set { delivered = value; }
        }
    }
    class order1
    {
        static void Main(string[] args)
        {
            Order2 e = new Order2();
            e.Order_id = 101;
            e.Cust_name = "Akshay";
            e.City = "Pune";
            e.Delivered = "Yes";
            Console.WriteLine(e.Order_id + " " + e.Cust_name + " " + e.City + " " + e.Delivered);
        }
    }


}
