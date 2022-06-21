using System;

namespace ConsoleApp3
{
    class dscandasc//revision prob
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
    class digitsum1
    {
        static void Main(string[] args)
        {
            int num = 126835;
            int sum = 0;
            int remainder;
            int count = 0;


            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;
                if (remainder % 2 == 0)
                {
                    count++;

                    sum = sum + remainder;

                }

            }

            Console.WriteLine(sum / count);

        }
    }
}
