using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3.basic_problem
{
    class arayeven
    {
        static void Main(string[] args)
        {
            
            int[] a = { 3, 4, 6, 7, 8, 9 };
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                    Console.WriteLine(" " + a[i]);

              
               
            }
           
        }
    }
   
    class program//array practice

    {
        private static void Main(string[] args)
        {
            //string car1 = "mariuti";
            //string car2 = "ford";
            //string car3 = "bmw";
            //string car4 = "ferrari";

            //string[] cars = { "mariuti", "ford", "bmw", "ferrari" };
            string[] cars = new string[4] { "maruti", "ford", "bmw", "ferrari" };
            //for(int i=0;i<cars.Length;i++)
            //{

            //    Console.WriteLine(cars[i]);
            //}
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            //Console.WriteLine(cars[3]);
        }
    }
    class arprog//practice
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };

            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class arrayex
    {
        private static int i;

        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 6, 23, 6 };
            int[] a = new int[4];
            Console.WriteLine("enter array value");
            for (int i = 0; i < a.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                a[i] = x;

            }
            Console.WriteLine("///////////////");
            //1.
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("///////");
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("////////////////");
            a.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("/////////////");
            Console.WriteLine(string.Join(" ", a));
        }
    }
    class Reversearray
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };
            foreach (int p in a)
            {
                Console.WriteLine(p + " ");
            }
            Console.WriteLine("/////////");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i] + " ");
            }


        }
    }
    class arraysum
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
    }
    class primenumb
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8, 3, 9, 7 };

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(a[i]);

                }

            }

        }
    }
    //class art
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("enter the size");
    //        int x = int.Parse(Console.ReadLine());
    //        int[] a = new int[x];
    //        Console.WriteLine("enter the array elent");
    //        for(int i=0;i<a.Length;i++)
    //        {
    //            int e = int.Parse(Console.ReadLine());
    //            a[i]= e;
    //            int n = a[i];
    //            bool isprime = true;
    //            for(int j=2;j<a.Length;j++)
    //            {

    //                if(n%j==0)
    //                {
    //                    isprime = false;
    //                    break;

    //                }
                   

                    
    //            }
    //            if (isprime == true)
    //            {
    //                Console.WriteLine(a[i]);
    //            }

                
                    
                
    //        }
            
    //    }
    //}
    class alternate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of array:");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            Console.WriteLine("enterr array element:");
            for (int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("array element are:");
            foreach (int ele in a)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine("alternate array element are:");
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
        }
        class oddpositionele
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the length of array");
                int x = int.Parse(Console.ReadLine());
                int[] a = new int[x];
                Console.WriteLine("enterr the arrray element:");
                for (int i = 0; i < a.Length; i++)
                {
                    int e = int.Parse(Console.ReadLine());
                    a[i] = e;
                }
                Console.WriteLine("array element are:");
                foreach (int ele in a)
                {
                    Console.WriteLine(ele + " ");

                }
                Console.WriteLine();
                Console.WriteLine("odd position element are:");
                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(a[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

    }
    class Arrayreversedemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine(string.Join(" ", ch));

            Console.WriteLine();
            Console.WriteLine("////////");
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write(ch[i] + " ");
            }
        }
    }
    class Reverse
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine(String.Join(" ", ch));
            Console.WriteLine();
            Console.WriteLine("////////////////");
            int j = ch.Length - 1;
            for (int i = 0; i <= ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;

            }
            Console.WriteLine(String.Join(" ", ch));

        }
    }
    class arrayswapi//Hw
    {
        static void Main(string[] args)
        {
            int[] sw = { 3, 8, 5, 6, 7 };
            Console.WriteLine(String.Join(" ", sw));
            Console.WriteLine();
            Console.WriteLine("//////////////");
            int j = sw.Length - 1;
            for (int i = 0; i <= sw.Length / 2; i++)
            {
                int temp = sw[i];
                sw[i] = sw[j];
                sw[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ", sw));
        }
    }
    class maxelement
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 3, 1, 8, 2 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("max=" + max);

        }
    }
    class max1
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
            
        }
    }

    class minimumelement//minimum HW
    {
        static void Main(string[] args)
        {
            int[] b = { 95, 90, 67, 85, 89 };
            int min = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < min)
                {
                    min = b[i];
                }
            }
            Console.WriteLine("min" + min);
        }
    }
    class primenumbsum
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8, 3, 9, 7 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];

                }

            }
            Console.WriteLine(sum);
            
        }
    }
    class psum
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            int n,  sum = 0;
            for(int i=0;i<b.Length;i++)
            {
               
                n = b[i];
                bool isprime = true;
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime=true)
                {
                    Console.WriteLine( b[i]);
                    sum = sum + b[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
    class Occurence
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 2, 9, 2, 8, 5, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    /* if (count == 1)/ /.........SHOW ONLY OCC AS PER WISH THAN 1*/
                    Console.WriteLine(a[i] + " " + count);
                }
            }

        }
    }
    class Mergearray//homework
    {
        static void Main(string[] args)

        {

            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8 };
            int range = a.Length + b.Length;
            int[] c = new int[range];
            Console.WriteLine("first array is:" + string.Join(" ", a));
            Console.WriteLine("second arrayn is:" + string.Join(" ", b));
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int j = 0, k = a.Length; k < range && j < b.Length; j++, k++)
            {
                c[k] = b[j];
            }
            Console.WriteLine("array after combining:" + string.Join(" ", c));
        }
    }
    //class Alternatmerg
    //{
    //    static void Main(string[] args)
    //    {
    //       int  index1=0,index2 = 0;
    //        int[] a = { 1, 2, 3, 4 };
    //        int[] b = { 5, 6, 7, 8 };
    //        int range = a.Length + b.Length;
    //        int[] c = new int[range];
    //        Console.WriteLine("first array is:" + string.Join(" ", a));
    //        Console.WriteLine("second arrayn is:" + string.Join(" ", b));
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            c[index1] = a[i];
    //            index1 += 2;
    //        }
    //        for(int i=0;i<b.Length;i++)
    //        {
    //            c[index2] = b[i];
    //            index2 += 2;
    //        }
    //        Console.WriteLine("array after combining:"+string.Join(" ",c));
    //    }
    //}


    class Searcharray
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 4, 2, 9, 1 };
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("enter the number for searched");
            int num = Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("not present");
            }
        }
    }

    class Occurenceevenodd//class hw
    {
        static void Main(string[] args)
        {
            int i, n, even = 0, odd = 0;
            Console.WriteLine("Enter the number of elements to be inserted: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    
                    even++;
                }
                else
                {
                    
                    odd++;
                }
            }
            Console.WriteLine("Number of even terms are: " + even);
            Console.WriteLine("Number of odd terms are: " + odd);
            Console.ReadLine();
        }
    }
    class Avgofodd//HOMEWORK CLASS
    {
        static void Main(string[] args)
        {
            int size;
            int oddSum = 0, evenSum = 0;
            int oddCount = 0, evenCount = 0;

            Console.WriteLine("Enter the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the array values:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int value in arr)
            {
                if (value % 2 == 0)
                {
                    evenSum += value;
                    evenCount++;
                }
                else
                {
                    oddSum += value;
                    oddCount++;
                }
            }

            Console.WriteLine("Even average: " + evenSum / evenCount + " Odd average: " + oddSum / oddCount);
        }
    }
    class sortingarray//ascending order
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("enter array element");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(".........................");
            Console.WriteLine(string.Join(" ", ch));
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }
            Console.WriteLine("...........after...........");
            Console.WriteLine(String.Join(" ", ch));
            //for(int i=0;i<ch.Length;i++)
            //{
            //    Console.WriteLine(ch[i]);
            //}


        }
    }
   
    class sortarray//int typr....homework
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
                    if (ar[i] < ar[j])//"<" indicate discending order
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
   
    class discen_ascend//revision prob
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the original array is");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (j < a.Length / 2)
                    {
                        if (a[i] > a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                    else
                    {
                        if (a[i] < a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("array after discending half");
            Console.WriteLine(String.Join(" ", a));



        }
    }
    class sortmethod
    {
        int[] DoSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])//"<" indicate discending order
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 2, 8, 4 };
            sortmethod m = new sortmethod();
            int[] newArray = m.DoSort(a);

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
    class sortintarray//negative integer square
    {
        static void Main(string[] args)
        {
            int[] a = { 1, -2, 3, -6, 5, -8 };
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i] * a[i]);
                    ;
                }
                else
                    Console.WriteLine(a[i]);
            }
        }
    }

    class twodararaydemo//multidimmensional array start
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(".............................");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("..................");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class multiarray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 5, 4, 3, 3 }, { 7, 8, 1, 6 }, { 9, 2, 3, 4 }, { 3, 5, 1, 9 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("////////////////////");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
    class dimmentwoarray
    {
        static void Main(string[] args)
        {
            char[,] ch = new char[4, 4];
            for(int i=0;i<=ch.GetUpperBound(0);i++)
            {
                for(int j = 0; j <= ch.GetUpperBound(1); j++)
                {
                    if (i == 0 || j == 0 || i == ch.GetUpperBound(0) || j == ch.GetUpperBound(1))
                    {
                        ch[i, j] = '*';
                    }
                    else
                    {
                        ch[i, j] = ' ';
                    }
                }
            }
            for (int i = 0; i <= ch.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ch.GetUpperBound(1); j++)
                {
                    Console.Write(ch[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
    class twodarraydemosum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 4, 5 }, { 1, 6, 7 }, { 3, 2, 1 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write(" " + sum);
                Console.WriteLine();
            }
        }
    }






}
    


















