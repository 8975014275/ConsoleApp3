using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.loop_test_3
{
    class Occurenceevenodd
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

        }
    }
    class Test
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100) + " " + mcCartyCounter);
        }
        //this is static test
        //HI this parameter= 200
        //HI this parameter= 400
    }
    class Occurencecg
    {
        static void Main(string[] args)
        {
            char[] a = { 'a', 'b', 'b', 'c', 'c', 'b' };
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
                     if (count == 1)
                    Console.WriteLine(a[i]);
                }
            }

        }
    }
    class zermoving
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])//"<" indicate discending order
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }
               
            }
            Console.WriteLine(String.Join(" ", a));
        }
    }
    class remoduplicate
    {
        static void Main(string[] args)
        {
            int[] ar = { 4,3,2,4,9,2 };//3,9
            for (int i = 0; i < ar.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ar[k] == ar[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < ar.Length; j++)
                    {
                        if (ar[i] == ar[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                        Console.WriteLine(ar[i]);
                }
            }

        }
    }
    class number
    {
        static void Main(string[] args)
        {
            int[] var = new int[10];
            for(int i=0;i<10;i++)
            {
                var[i] = i;
                Console.WriteLine(var[i]+" ");
                i++;
            }
        }
    }
    //public class ArrayOuput
    //{
    //    public static void main(String[] args)
    //    {
    //        int a1[], a2;
    //        a1 ={ 1,2,3};
    //        a2 = new String[a1.length];
    //        for (int i = 0; i < a1.length; i++)
    //        {
    //            a2[i] = a1[i];
    //        }
    //        for (int i = 0; i < a2.length; i++)
    //        {

    //            Console.WriteLine(a2[i]);
    //        }
    //    }
    //}
    class PERFECTSQ
    {
        static void Main(string[] args)
        {
            int[] b = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine("array element are :"+string.Join(" ",b));
            Console.WriteLine("perfect square element are:");
            for(int i=0;i<b.Length;i++)
            {
                for(int j=1;j<b[i];j++)
                {
                    if(b[i]%j==0 && b[i]/j==j)
                    {
                        Console.WriteLine(b[i]);
                    }
                }
            }
        }
    }
    class Myrefil
    {
        private string color;
        private int length;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
    }
    class Mynib
    {
        private string nib_material;
        private int width;

        public string NibMaterial
        {
            get { return nib_material; }
            set { nib_material = value; }

        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Mypen
    {
        private string brand_name;
        private int caplength;
        Myrefil refil;
        Mynib nib;

        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public Myrefil Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public Mynib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        static void Main(string[] args)
        {
            Mypen p = new Mypen();
            p.Brand_name = "REYNOLDS";
            p.Caplength = 5;
            p.Refil = new Myrefil();
            p.Refil.Color = "BLUE";
            p.Refil.Length = 4;

            p.Nib = new Mynib();
            p.Nib.NibMaterial = "GOLD ALLOY";
            p.Nib.Width = 1;

            Console.WriteLine(p.Brand_name + " " + p.Caplength + " " + p.Refil.Color + " " + p.Refil.Length + " " + p.Nib.NibMaterial + " " + p.Nib.Width);




        }
    }
    class loop
    {
        static void Main(string[] args)
        {
            int buzz = 0, fizz = 0, buzzfizz = 0;

            for (int i = 1; i <= 50; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    buzzfizz++;
                    Console.WriteLine("buzzfizz");
                }
                else if (i % 3 == 0)
                {
                    fizz++;
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    buzz++;
                    Console.WriteLine("buzz");

                }
                else
                    Console.WriteLine(i);


            }
            Console.WriteLine("buzzfizz="+buzzfizz);
            Console.WriteLine("fizz="+fizz);
            Console.WriteLine("buzz="+buzz);
        }
    }
  









}
