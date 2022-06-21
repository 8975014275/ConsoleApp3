using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.stringarraytest
{
    class Anagram1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort((ch2));
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("string are anagram");

            }
            else
                Console.WriteLine("string are not anagram");
        }
    }
    class countword
    {
        static void Main(string[] args)
        {
            string str;
            int count = 1, length = 0;
            Console.WriteLine("enter a string");
            str = Console.ReadLine();
            while (length <= str.Length - 1)
            {
                if (str[length] == ' ' || str[length] == '\n' || str[length] == '\t')
                {
                    count++;
                }
                length++;
            }
            Console.WriteLine(count);
        }
    }
    class sortascending
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            Console.WriteLine("enter the number");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("..............");
            Console.WriteLine(String.Join(" ", ar));
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] < ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }

                }
            }
            Console.WriteLine("after.......");
            Console.WriteLine(String.Join(" ", ar));
        }
    }
    class charstrmethodtog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);
                }
                newstr = newstr + ch;

            }
            Console.WriteLine(newstr);
        }
    }
    class minchar
    {
        static void Main(string[] args)
        {
            char[] ch = { 'A', 'D', 'E', 'x', 'z','R' };
            Console.WriteLine(String.Join(" ",ch));
            char min;
            min = ch[0];
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]<min)
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("min element:"+min);
        }
    }

    class uniqelement
    {
        static void Main(string[] args)
        {
            int[] c = { 2, 3, 5, 3, 7, 5 };
          

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < c.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (c[i] == c[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(c[i]);

                }
            }
        }

    }
    class mergearray3
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 44, 66, 77, 88 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;

            }
            for(int i=0;i<b.Length;i++)
            {
                c[j] = b[i];
                j++;
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine(string.Join(" ",c));

        }
    }
    class arithmeticop
    {
        static void Main(string[] args)
        {
            int sum, substraction, multiplication, division;
            int num1, num2;
            Console.WriteLine("enter the number1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            substraction = num1 - num2;
            multiplication = num1 * num2;
            division = num2 / num1;
            Console.WriteLine(sum);
            Console.WriteLine(substraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);

        }
    }
    class arearectan
    {
        static void Main(string[] args)
        {
            int l = 7;
            int b = 8;
            int area;
            area = l * b;
            Console.WriteLine("area of reactangle:" + area);
        }
    }
    class simpleinterest
    {
        static void Main(string[] args)
        {
            double simpleinterest;
            Console.WriteLine("enter the principle amount");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the time in year");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the rate percent");
            int r = int.Parse(Console.ReadLine());
            simpleinterest = (p * t * r) / 100;
            Console.WriteLine("simple interrest is:" + simpleinterest);

        }
    }
    class convertlength
    {
        static void Main(string[] args)
        {
            float cm, meter, kilometer;
            Console.WriteLine("enter length in centimeter");
            cm = float.Parse(Console.ReadLine());
            meter = cm / 100;
            kilometer = cm / 100000;
            Console.WriteLine(":cm into meter length=" + meter);
            Console.WriteLine("cm into kilomrter=" + kilometer);
        }
    }
    class cubeofnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the nim");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine("cube of number is" + cube);
        }
    }
    class sqrnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            int sqnumber = a * a;
            Console.WriteLine("sqnumber is:" + sqnumber);
        }
    }
    class SubAvgper
    {
        static void Main(string[] args)
        {


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
    class rectangleperi
    {
        static void Main(string[] args)
        {
            int l = 5;
            int b = 8;
            int perimeter;
            perimeter = 2 * (l + b);
            Console.WriteLine("perimeter of rectangle:" + perimeter);
        }
    }
    class triarea1
    {
        static void Main(string[] args)
        {
            double b, h, area;
            b = 10;
            h = 12;
            area = 0.5f * b * h;
            Console.WriteLine("area of triangle=" + area);
        }

    }




}
