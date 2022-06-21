using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.basic_problem
{
    class Array
    {

        // Main Method
        public static void Main()
        {
            // Step 1: Array Declaration
            string[] arr;

            // Step 2:Array Initialization
            arr = new string[3] { "ONE", "TWO", "THREE" };

            // Step 3:Accessing Array Elements
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            // ONE
            // TWO
            //THREE
        }

        internal static void Sort(char[] char1)
        {

        }
    }
    class Merge
    {
        static void Main(string[] args)
        {
            //int[] c = { 1, 2, 3, 4, 5 ,6,7,8,9,10};
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                a[i] = b[i];
                // c[i] = a[i];


            }
            for (int i = 0; i < a.Length; i++)
            {

                c[i + b.Length] = b[i];

            }
            for (int i = 0; i < c.Length; i++)

                Console.Write(c[i] + " ");
            //0 0 0 0 0 6 7 8 9 10
        }
    }
    class arrays
    {
        static void Main(string[] args)
        {
            int[] marks = new int[3];

            marks[0] = 98;
            marks[1] = 97;
            marks[2] = 95;
            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]);
            //Console.WriteLine(marks[2]);
            for (int i = 0; i < 3; i++)
                Console.WriteLine(marks[i]);
            //98
            //97
            //95

        }
    }
    class arrays1
    {
        static void Main(string[] args)
        {
            int[] marks = { 98, 97, 95 };
            for (int i = 0; i < 3; i++)
                Console.WriteLine(marks[i]);
        }
    }
    class arrays2
    {
        // Taking an array as an input and printing its elements
        static void Main(string[] args)
        {
            Console.WriteLine();
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //5

            //1

            //2

            //3

            //4

            //5
            //1
            //2
            //3
            //4
            //5


        }
    }

    class frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many elements you want insert initially");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size1];
            for (int i = 0; i < size1; i++)
            {

                int x = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine(x);

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                //if(numbers[i]==x)
                {
                    Console.WriteLine("x found at index: " + i);
                }

            }
            //how many elements you want insert initially
            //  6
            //  1
            //  2
            //  3
            //  4
            //  5
            //  7
            //  x found at index: 0
            //  x found at index: 1
            //  x found at index: 2
            //  x found at index: 3
            //  x found at index: 4
            //  x found at index: 5


        }
    }
    class namestr
    // Take an array of names as input from the user and print them on the screen.

    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many elements you want insert initially");
            int size2 = Convert.ToInt32(Console.ReadLine());
            String[] names = new String[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine();
                names[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(" name " + (i + 1)/*(i)*/ + " is : " + names[i]);
            }
            //how many elements you want insert initially
            //4

            //1

            //2

            //3

            //5
            // name 1 is : 1
            // name 2 is : 2
            // name 3 is : 3
            // name 4 is : 5

        }
    }

    class minmax
    {
        static void Main(string[] args)
        {
            //minimum maximum value
            Console.WriteLine("how many elements you want insert initially");
            int size3 = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size3];
            for (int i = 0; i < size3; i++)
            {
                Console.WriteLine("");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = int.MinValue;

            int min = int.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];

                }
                if (num[i] > max)
                {
                    max = num[i];

                }
            }
            Console.WriteLine("Largest number is : " + max);
            Console.WriteLine("Smallest number is : " + min);
            //            how many elements you want insert initially
            //3

            //22

            //33

            //55
            //Largest number is : 55
            //Smallest number is : 22
        }
    }

    class ascdsc1
    {
        static void Main(string[] args)
        {
            /*Take an array of numbers as input and check if it is an array sorted
            in ascending order. 
            Eg : { 1, 2, 4, 7 } is sorted in ascending order. 
                 {3, 4, 6, 2} is not sorted in ascending order.
            */
            Console.WriteLine("how many elements you want insert initially");
            int size4 = Convert.ToInt32(Console.ReadLine());
            int[] numb = new int[size4];
            for (int i = 0; i < size4; i++)
            {
                Console.WriteLine();
                numb[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool isAscending = true;
            for (int i = 0; i < numb.Length - 1; i++)
            {
                if (numb[i] > numb[i + 1])
                {
                    isAscending = false;
                }
                if (isAscending)
                {
                    Console.WriteLine("The array is sorted in ascending order");
                    //   how many elements you want insert initially
                    //   3

                    //   1

                    //   2

                    //   3
                    //The array is sorted in ascending order
                    //The array is sorted in ascending order
                }
                else
                {
                    // Console.WriteLine("The array is not sorted in ascending order");
                    // how many elements you want insert initially
                    // 3

                    // 4

                    // 3

                    // 2
                    //The array is not sorted in ascending order
                    //The array is not sorted in ascending order

                }
            }
        }
    }
    class pair
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int sum = 10;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] + a[j] == sum)
                        Console.WriteLine($"pair that gives sum =10 is {a[i]}+{a[j]}");
                    //pair that gives sum = 10 is 2 + 8
                    //pair that gives sum = 10 is 3 + 7
                    //pair that gives sum = 10 is 4 + 6
                    //pair that gives sum = 10 is 5 + 5
                    //pair that gives sum = 10 is 9 + 1
                }

            }
        }
    }
    class merge3alt
    {
        static void Main(string[] args)
        {
            {
                int[] d = { 1, 2, 3, 4, 5, 6, 7, 8 };
                int[] e = { 11, 22, 33, 44 };
                int[] f = new int[d.Length + e.Length];
                int k = 0;
                for (int i = 0; i < f.Length; i++)
                {
                    if (k < d.Length && k < e.Length)//same
                    {
                        f[i] = d[k];
                        i++;
                        f[i] = e[k];
                        i++;
                    }
                    else if (k < d.Length)
                    {
                        f[i] = d[k];
                        i++;
                    }
                    else
                    {
                        f[i] = e[k];
                        i++;
                    }
                    k++;

                    // ERROR
                }
            }
        }
    }
    class swapp
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11 });
            Console.Write("After swapping first and last elements: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static int[] test(int[] numbers)
        {
            int first = numbers[0];
            int second = numbers[1];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[1] = numbers[numbers.Length - 2];
            numbers[numbers.Length - 1] = first;
            numbers[numbers.Length - 2] = second;

            return numbers;
            //After swapping first and last elements: 11 9 7 5 1
        }

    }

    class swapps
    {
        public static void Main(string[] args)
        {
            int i, t;
            int[] arr = new int[10];

            Console.WriteLine("Enter ten numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            i = 0;
            while (i < arr.Length - 1)
            {
                t = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = t;
                i = i + 2;
            }

            Console.Write("List after swapping:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //Enter ten numbers:
            //1
            //2
            //3
            //4
            //5
            //6
            //7
            //8
            //9
            //0 
            //List after swapping: 2 1 4 3 6 5 8 7 0 9
        }
    }
    class Class200
    {
        static void Main(string[] args)
        {
            double total_marks = 500;

            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter marathi marks under range 0-100");
            double marathi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter hindi marks under range 0-100");
            double hindi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter english marks under range 0-100");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter maths marks under range 0-100");
            double maths = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter science marks under range 0-100");
            double science = Convert.ToDouble(Console.ReadLine());

            double obtained_marks = (marathi + hindi + english + maths + science);
            //double average = (marathi + hindi + english + maths + science) / 5;
            Console.WriteLine(obtained_marks);
            // Console.WriteLine(average);

            double percentage = obtained_marks / total_marks * 100;
            Console.WriteLine(percentage);
        }
    }



}
