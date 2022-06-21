using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Animal
    {
        public int x = 100;
        public static int y = 500;

        public Animal(string name)
        {
            Console.WriteLine("Animal Constructor" + " " + name);
        }

        public abstract void show();

        public void Myanimal()
        {
            Console.WriteLine("MY ANIMAL");
        }
    }
    class Dog : Animal
    {
        public Dog() : base("Rocky")
        {
            Console.WriteLine("Dog Constructor");
        }
        public override void show()
        {
            Console.WriteLine("Dog" + " " + x + " " + y);
        }

    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.show();
            a.Myanimal();

        }
    }
    public interface Imoveable
    {
        static int x;
        void show();

        static void Mymethod()
        {
            Console.WriteLine("My static interface method");
        }
        void foo()
        {
            Console.WriteLine("foo method");
        }
    }
    class car : Imoveable
    {
        public void show()
        {
            Imoveable.x = 400;
            Console.WriteLine("My interface method" + Imoveable.x);
        }
    }
    class interfacedemo
    {
        static void Main(string[] args)
        {
            Imoveable m = new car();
            m.show();
            Imoveable.Mymethod();
            m.foo();

        }
    }
    public interface IPrintable
    {
        static int y = 500;

        void print();

    }
    public interface IMoveable
    {
        static int x;
        void show();
        static void Mymethod()
        {
            Console.WriteLine("my static interface method");
        }
        void foo()
        {
            Console.WriteLine("foo method");
        }
    }
   class Car: IMoveable, IPrintable
    {
        public void show()
        {
            IMoveable.x = 400;
            Console.WriteLine("My interface method" + IMoveable.x);
        }
        public void print()
        {
            Console.WriteLine("Hii i am printable...."+(IPrintable.y+ IMoveable.x));
        }
        
    }
    class Interfacedemo
    {
        static void Main(string[] args)
        {
            IMoveable m = new Car();
            m.show();
            IMoveable.Mymethod();
            m.foo();
            IPrintable p = new Car();
            p.print();


        }
    }
}
