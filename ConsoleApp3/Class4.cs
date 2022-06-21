using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class checknumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine("negative number");
            }
            else
            {
                Console.WriteLine("zero");
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
            {
                Console.WriteLine(" odd num");
            }
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
    class maxnum
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
    class areaeqtriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            float side = float.Parse(Console.ReadLine());
            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;
            Console.WriteLine("araa of rectanglr =" + area);

        }
    }
    class vow2elconso
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
    class vowelc
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
    class vcnf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;

            }

        }
    }
    class addsubmul
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ener the second num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.addition\n 2.substraction\n 3.multiplication\n 4.division\n");
            Console.WriteLine("enter the choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("addition" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("substraction" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("multiplication" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("division" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }

        }
    }
    class daynum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thursday");
                    break;
                case 6:
                    Console.WriteLine("friday");
                    break;
                default:
                    Console.WriteLine("saturday");
                    break;

            }
        }
    }
    class evod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine(num + "is even number");
                    break;
                case 1:
                    Console.WriteLine(num + "is odd number");
                    break;
            }

        }
    }
    class Armstrong1
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
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());

            int c = 0;
            int sum = 0;
            while (a > 0)
            {
                int digit = a % 10;
                c++;

                sum = sum + digit;
                a = a / 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(c);

        }
    }
    class digsum
    {
        static void Main(string[] args)
        {
            int num, sum = 0, firstdigit, lastdigit;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            lastdigit = num % 10;
            firstdigit = num;
            while (num >= 10)
            {
                num = num / 10;
            }
            firstdigit = num;
            sum = firstdigit + lastdigit;
            Console.WriteLine(sum);
        }
    }
    class odevenfolo
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------------------------------------------------");
            for (int j = 1; j <= 30; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
    class revnum
    {
        static void Main(string[] args)
        {
            int originalnumber, reversenumber = 0;
            Console.WriteLine("enter the number");
            originalnumber = Convert.ToInt32(Console.ReadLine());
            while (originalnumber >= 1)
            {
                reversenumber = reversenumber * 10 + originalnumber % 10;
                originalnumber = originalnumber / 10;
            }
            Console.WriteLine(reversenumber);

        }
    }
    class evennoddsq
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {

                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i * i);
            }
        }

    }
    class seri3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.Write((i * i) + (i * i * i) + " ");
            }
        }
        // 2 12 36 80 150 252 392 576 810 1100
    }
    class whidemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
    class whidemo1
    {
        static void Main(string[] args)
        {
            int i = 86;
            while (i >= 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    class magicnumber
    {
        static void Main(string[] args)
        {

            int magicnumber = 45;
            for (; ; )
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num > magicnumber)
                {
                    Console.WriteLine("number is greater try again");
                    continue;
                }
                else if (num < magicnumber)
                {
                    Console.WriteLine("number is less try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("magic number is correct");
                }


            }
        }





    }
    class nestedl
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------");
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------");

        }

    }
    class loopss1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //  1
            //  22
            //  333
            //  4444
        }
    }
    class loopss2
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 4; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    //4444
    //333
    //22
    //1

    class loopss5
    {
        static void Main(string[] args)
        {
            int i, j;
            int num = 1;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + "  ");
                    num++;
                }
                Console.WriteLine();
            }

        }
    }
    //1
    //2 3
    //4 5 6
    //7 8 9 10
    class loopss6
    {
        static void Main(string[] args)
        {
            int i, j;
            int num = 1;
            for (i = 4; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
    //1 2 3 4
    //5 6 7
    //8 9
    //10
    class loopsscombo
    {
        static void Main(string[] args)
        {
            int i, j;
            int num = 1;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + "  ");
                    num++;
                }
                Console.WriteLine();
            }
            for (i = 4; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
    class loops101
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i + j;
                    if (sum % 2 == 0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
    //1
    //0 1
    //1 0 1
    //0 1 0 1
    //1 0 1 0 1
    class loops101R
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i + j;
                    if (sum % 2 == 0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
    //1 0 1 0 1
    //0 1 0 1
    //1 0 1
    //0 1
    //1
    class loops101COMBO
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i + j;
                    if (sum % 2 == 0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i + j;
                    if (sum % 2 == 0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
    class dh
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i > 10);




        }
    }
    class menudr
    {
        static void Main(string[] args)
        {
            char ch;



            do
            {
                Console.WriteLine("1.addition\n 2.substraction\n 3.multiplication\n 4.division");
                Console.WriteLine("enter the choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("ener the number1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the num2");
                int num2 = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("addition" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("substraction" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multiplication" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("do you want to continue");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'n');
        }
    }
    class menudrareas
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("area of calculation");
                Console.WriteLine("1.circle\n 2.rectangle\n 3.triangle\n 4.sqare");
                Console.WriteLine("enter the choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("area of circle:" + (3.14f * num1 * num2));
                        break;
                    case 2:
                        Console.WriteLine("area of rectangle:" + (num1 * num2));
                        break;
                    case 3:
                        Console.WriteLine("area of triangle:" + (0.5f * num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("area of square:" + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;


                }
                Console.WriteLine("do you want to continue");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'n');
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
    class automorphic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sq = num * num;
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            int power = 1;
            while (count > 0)
            {
                power = power * 10;
                count--;

            }
            Console.WriteLine(power);
            num = temp;
            int end = sq % power;
            if (num == end)
            {
                Console.WriteLine("automorphic");
            }
            else
            {
                Console.WriteLine("not");
            }

        }
    }
    class disarium
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 1;
                int power = 1;
                for (int i = 1; i <= count; i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("disarium");
            }
            else
            {
                Console.WriteLine("not");
            }
        }

    }
    class table
    //1 to 5
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 5; num++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(num * i + " ");
                }
            }


        }
    }
    class loopss3
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    //1
    //12
    //123
    //1234


   
        class loop5
        {
            static void Main(string[] args)
            {
                int i, j;
                int num = 1;
                for (i = 1; i <= 3; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(num + "  ");
                        num++;
                    }
                    Console.WriteLine();
                }

            }
        }
        class loop6
        {
            static void Main(string[] args)
            {


                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(j);

                    }
                    Console.WriteLine();
                }

            }
        }
        class HOLORECTANGLE
        {
            static void Main(string[] args)
            {
                //****
                //*  *
                //*  *
                //****

                int c = 4;
                int r = 4;
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= r; j++)
                    {
                        if (i == 1 || j == 1 || i == c || j == r)
                            Console.Write("*");

                        else

                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }
        }
        class PatternN
        {
            static void Main(string[] args)
            {
                for (int r = 1; r <= 5; r++)
                {
                    for (int c = 1; c <= 5; c++)
                    {
                        if (c == 1 || c == 5 || r == c)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }
        }
    class pyramid
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=4;i++)
            {
                for(int space=1;space<=4-i;space++)
                    Console.Write(" ");
                for(int j=1;j<=i;j++ )
                    Console.Write('*');
                for( int j=(i-1);j>=1;j--)
                    Console.Write('*');
                Console.WriteLine();
                
            }
        }
    }































    
}
























