using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.basic_problem
{
    class strdemo
    {
        static void Main(string[] args)
        {
            string str = "HEllo C#";//keyword
            string s = "Hello DotNet";//literal
            string s1 = new string("Hello My programming");
            int l = s1.Length;
            Console.WriteLine("Length:" + l);

            string str1 = "Hello";
            string str2 = "Hello";
            //Console.WriteLine(str1==str2);
            //str1=str1+ str2;
            //Console.WriteLine(str1==str2);
            //Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            //Console.WriteLine(str1=str2);
            //str1 = str1 + "c#";
            //Console.WriteLine(str1);
            //Console.WriteLine(str1==str2);
            //Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            string st = string.Concat(str1, "Pune");
            Console.WriteLine(st + " " + str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(x);

            int y = s1.LastIndexOf('r');
            Console.WriteLine(y);

            string s3 = s1.Substring(4);
            Console.WriteLine(s3);

            string s4 = s1.Substring(4, 7);
            Console.WriteLine(s4);

            string mystring = "java,c#,c++,python";
            string[] s5 = mystring.Split(",");
            foreach (string ss in s5)
            {
                Console.WriteLine(ss);
            }

            Console.WriteLine(string.Join(" ", "pune", " ", "Welcome"));

            string s6 = "     pune    ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            Console.WriteLine(s1[10]);

        }
    }
    class methodstring
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str1 = new string("hello");
            Console.WriteLine(str == str1);
            Console.WriteLine(str.Equals(str1));

            int i = str.CompareTo(str1);
            Console.WriteLine(i);
        }
    }
    class reversestring//string convert char array reverse the string
    {
        static void Main(string[] args)
        {
            string str = "India is my Country";
            char[] ch = str.ToCharArray();
            int j = ch.Length - 1;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ", ch));
            string st = new string(ch);
            Console.WriteLine(st);
        }
    }
    class reversestr
    {
        static void Main(string[] args)
        {
            string str = "India is my Country";
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
        }
    }
    class reverseword1
    {
        static void Main(string[] args)
        {
            string str = "c# is easy";
            string[] str1 = str.Split(" ");
            string reverse = "";
            for (int i = 0; i < str1.Length; i++)
            {
                string word = str1[i];
                string myword = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    myword = myword + word[j];
                }
                reverse = reverse + myword + " ";
            }
            Console.WriteLine(reverse);

        }
    }
    class countstringcounter
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = "hello how are you";
            foreach (char item in input)
            {
                if (item == 'h')
                {
                    count++;
                }
            }
            Console.WriteLine("count of 'h'=" + count);
        }
    }
    class countword//homework
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

    class counword//word count
    {
        static void Main(string[] args)
        {
            string str = "i like india";
            string[] s = str.Split(" ");
            Console.WriteLine(s.Length);
        }
    }


    class pattern//for word pattern  
    {
        static void Main(string[] args)
        {
            string str = "I like India country";
            string[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine();

            }


        }
    }
    class prsumstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            double sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }
    }
    class pr//homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            double sum = 0;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    count++;
                    sum = sum + x;
                }
            }
            Console.WriteLine("average=" + (sum / count));
        }
    }
    class strsummethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }

    }
    class charstrringtog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);

                }
                else
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
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
                else if (char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
    class charstrmethodtog1
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
                    ch = char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    ch = char.ToUpper(ch);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
    class anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");
            string s = Console.ReadLine();
            Console.WriteLine("enter second string");
            string s1 = Console.ReadLine();

            string st1 = s.ToLower();
            string st2 = s1.ToLower();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();

            Console.WriteLine(string.Join(" ",ch1));
            Console.WriteLine(string.Join(" ", ch2));
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("////////////////////////");
            Console.WriteLine(string.Join(" ",ch1));
            Console.WriteLine(string.Join(" ",ch2));
            string str1 = new string(ch1);
            string str2 = new string(ch2);

            if (str1.Equals(str2))
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }
            //bool flag = true;
            //for(int i=0;i<ch1.Length;i++)
            //{
            //    if(ch1[i]!=ch2[i])
            //    {
            //        flag = false;
            //        break;

            //    }
            //    if(flag==true)
            //    {
            //        Console.WriteLine("anagram");
            //    }
            //    else
            //    {
            //        Console.WriteLine("not");
            //    }
            //}




        }
    }
    class Anagram1//s
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


    //class strbuild
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "HELLO";
    //        StringBuilder sb = new StringBuilder(str);
    //        sb.Append("PUNE");
    //        Console.WriteLine(sb);
    //    }
    //}
    class sb1
    {
        static void Main(string[] args)
        {
            string s = "Pune";
            StringBuilder sb = new StringBuilder(s);
            sb.AppendLine("City");
            Console.WriteLine(sb);
            sb.AppendLine(" for Fun");
            Console.WriteLine(sb);

            sb.Insert(6, "c#");
            Console.WriteLine(sb);
            sb.Remove(2, 6);
            Console.WriteLine(sb);
            //string s = "pune";
            //StringBuilder sb = new StringBuilder(s);
            //Console.WriteLine(sb);

            //StringBuilder sb2 = new StringBuilder("pune");
            //Console.WriteLine(sb2);

            //Console.WriteLine(sb.Equals(sb2));
            //Console.WriteLine(sb == sb2);






        }
    }
    


    //class Palstring//HOMEWORK
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "";
    //        Console.WriteLine("enter the string");
    //        str = Console.ReadLine();
    //        char[] a = str.ToCharArray();
    //        Array.Reverse(a);
    //        string str_reverse = new string(a);
    //        if (str.Equals(str_reverse))
    //        {
    //            Console.WriteLine(str + "=it is pallendrom string");
    //        }
    //        else
    //        {
    //            Console.WriteLine(str + "=it is not pallendrom string");
    //        }
    //    }
    //}
    //class strpattern//PRACTICE
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "";
    //        Console.WriteLine("enter the string");
    //        str = Console.ReadLine();
    //        char[] a = str.ToCharArray();

    //        for (int i = 0; i <= a.Length; i++)
    //        {
    //            for (int j = 0; j <= i; j++)
    //            {
    //                Console.Write(str[j] + " ");
    //            }
    //            Console.WriteLine();

    //        }
    //    }
    //}



}
