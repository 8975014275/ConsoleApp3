using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.test1writ
{
    class LeapYR
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
            Console.WriteLine();
        }

    }
    class SubAvg5
    {
        static void Main(string[] args)
        {
            //double total_marks = 500;

            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter marathi marks");
            double marathi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter hindi marks");
            double hindi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter english marks");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            double maths = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter science marks");
            double science = Convert.ToDouble(Console.ReadLine());

            double obtained_marks = (marathi + hindi + english + maths + science);
            double average = (marathi + hindi + english + maths + science) / 5;
            Console.WriteLine(obtained_marks);
            Console.WriteLine(average);

            double percentage = obtained_marks / 500 * 100;
            Console.WriteLine(percentage);
        }
    }
    class areaeqtriangle1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            float side = float.Parse(Console.ReadLine());
            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;
            Console.WriteLine("araa of trianglr =" + area);

        }
    }
    class Div511
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("number is divisible by 5 and 11");

            }
            else
                Console.WriteLine("number is not divisible by 5 and 11");


        }
    }
    class maxnum1
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else

            {
                max = num3;
            }
            Console.WriteLine(max);





        }
    }
    class vow2elconso1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = (Console.ReadLine())[0];//Char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
                Console.WriteLine("Consonent");


        }
    }
    class vowelc1
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter the alphabet");
            character = Char.Parse(Console.ReadLine());
            if ((character >= 'A' && character <= 'Z') || character >= 'a' && character <= 'z')
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')

                {
                    Console.WriteLine(character + " is vowel");
                }
                else
                {
                    Console.WriteLine(character + " is consonent");
                }
            }
            else
            {
                Console.WriteLine(character + " is not an alphabet");
            }

        }
    }
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num, remainder;
            num = Convert.ToInt32(Console.ReadLine());
            remainder = num % 2;
            if (remainder == 0)
            {
                Console.WriteLine("even number");
            }
            else
                Console.WriteLine(" odd num");

        }
    }
    class simcalculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter two values");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplition");
            Console.WriteLine("Enter 4 for Division");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    {
                        result = num1 + num2;
                        Console.WriteLine("Addition: " + result);
                        break;

                    }
                case 2:
                    {
                        result = num1 - num2;
                        Console.WriteLine("Subtraction: " + result);
                        break;

                    }
                case 3:
                    {
                        result = num1 * num2;
                        Console.WriteLine("Multiplition: " + result);
                        break;

                    }
                case 4:
                    {
                        result = num1 / num2;
                        Console.WriteLine("Division: " + result);
                        break;

                    }
                default:
                    Console.WriteLine("invalid number,EnterNUM WITHIN(1-4)");
                    break;
            }
        }
    }
    class Spclchar
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a Digit. ");
            }
            else
            
                Console.WriteLine(ch + " is a Special character.. ");
            
        }


    }
    class Opera
    {
        static void Main(String[] args)
        {
            int a = 5, b = 4, c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
        }
    }
}
