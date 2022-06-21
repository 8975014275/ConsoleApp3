using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.basic_problem
{
    class Sum1_2
    {
        static void Main(string[] args)
        {
            int num1, num2, addition;

            num1 = 5;
            num2 = 7;
            addition = num1 + num2;
            Console.WriteLine("Addition of two numbers=" + addition);
        }
    }
    class mult
    {
        static void Main(string[] args)
        {
            int num1, num2, multiplication;
            num1 = 15;
            num2 = 10;
            multiplication = num1 * num2;
            Console.WriteLine("multiplication of two number=" + multiplication);

        }
    }
    class rectare
    {
        static void Main(string[] args)
        {
            int length, breadth, area_of_rectrangle;
            length = 5;
            breadth = 7;
            area_of_rectrangle = length * breadth;
            Console.WriteLine("area_of_rectrangle =" + area_of_rectrangle);
        }
    }
    class triarea
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
    class sq
    {
        static void Main(string[] args)
        {
            int num, square;
            num = 25;
            square = num * num;
            Console.WriteLine("square of number=" + 25);


        }
    }
    class cube
    {
        static void Main(string[] args)
        {
            int num, cube;
            num = 5;
            cube = num * num * num;
            Console.WriteLine("cube of 5 is=" + cube);
        }
    }
    class sumofeven
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(sum);
        }
    }
    class primeornot
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
            {
                Console.WriteLine("prime");
            }
            else
                Console.WriteLine("not prime");
        }
    }

    class convert
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
    class si
    {
        static void Main(string[] args)
        {
            double pa, rate, time, si, total;
            pa = 1200;
            rate = 5;
            time = 6;
            si = (pa * time * rate) / 100;
            total = si + pa;
            Console.WriteLine("simple interest=" + si);
            Console.WriteLine("total amount=" + total);
        }
    }
    class perirect
    {
        static void Main(string[] args)
        {
            int l, b, perimeter;
            l = 12;
            b = 10;
            perimeter = 2 * (l * b);
            Console.WriteLine("perimeter of rectangle=" + perimeter);
        }
    }
    class salary
    {
        static void Main(string[] args)
        {
            double basic, gross, da, hra;
            Console.WriteLine("enter the basic salary of employee");
            basic = Convert.ToDouble(Console.ReadLine());
            if (basic <= 10000)
            {
                da = basic * 0.8;
                hra = basic * 0.2;

            }
            else if (basic < 20000)
            {
                da = basic * 0.9;
                hra = basic * 0.3;

            }
            else
            {
                da = basic * 0.95;
                hra = basic * 0.3;
            }
            gross = basic + hra + da;
            Console.WriteLine("gross salary of employee=" + gross);

        }
    }
    class Employee
    {
        public int id;
        public string Name;
        public int Age;
        public string Gender;

        public void setdata(int id, string name, int age, string gender)
        {
            this.id = id;
            Name = name;
            Age = age;
            Gender = gender;

        }
        public void getdata()
        {
            Console.WriteLine("ID : {0} NAME : {1} Age : {2} gender : {3}"
               , id, Name, Age, Gender);

        }



        static void Main(string[] args)
        {
            //int n = 10;
            Employee e1 = new Employee();
            e1.setdata(1, "Akshay", 26, "M");

            Employee e2 = new Employee();
            e2.setdata(2, "ajay", 25, "M");

            e1.getdata();
            e2.getdata();

        }

    }


    class Student
    {

        public int id;
        public String name;
        public double marks;


        static void Main(string[] args)
        {
            Student stu;
            stu = new Student();
            stu.id = 100;
            stu.name = "nikhil";
            stu.marks = 78.56;
            Console.WriteLine(stu.id + " " + stu.name + " " + stu.marks + " ");
        }
    }
    class Car
    {
        int modelno;
        string carname;
        string carcolor;
        int price;

        public void cardemo()
        {
            int modelno = int.Parse(Console.ReadLine());
            string carname = Console.ReadLine();
            string carcolor = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
        }
        public void display1()
        {
            Console.WriteLine("modelno:" + modelno + "carname:" + carname + "carcolor:" + carcolor + "price:" + price);
        }

        static void Main(string[] args)
        {
            Car c = new Car();
            for (int i = 1; i <= 2; i++)
            {
                c.display1();
            }
        }
       


    }
    class Car1
    {
        int model_no;
        string c_name;
        string c_color;
        int price;

        void input(int id,string name,string color,int pr)
        {
             model_no = id;
             c_name = name;
             c_color = color;
             price = pr;

        }
        void display()
        {
            Console.WriteLine(model_no+" "+ c_name+" "+ c_color+" "+ price);
        }
        static void Main(string[] args)
        {
            Car1 C = new Car1();
            C.input(2034, "BMW", "RED", 152452);
        }

    }
    class Car2
    {
        int model_no;
        string c_name;
        string c_color;
        int price;

        void input(int model_no, string c_name,string c_color,int price)
        {
            this.model_no = model_no;
            this.c_name = c_name;
            this.c_color = c_color;
            this.price = price;
        }
        void display()
        {
            this.input(455465, "AUDI", "BLACK", 976544);
            Console.WriteLine(model_no+" "+ c_color + " "+ c_name+" "+price);
            
        }
        static void Main(string[] args)
        {
            Car2 p = new Car2();
            p.display();
        }
    }
    class Demo
    {
        public int x;
        public void input(int x)
        {
            this.x = x;
        }
        public void show()
        {
            Console.WriteLine(x);
        }

    }
    class outsidemain
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.input(450);
            d.show();
        }
    }
      
    

    

    class Calculator
    {
        int num1;
        int num2;
        int result;

        public void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }

        public void Substract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.num1 = 50;
            obj.num2 = 30;
            obj.Add();
            obj.Substract();


        }

    }

    class Studentmarks
    {
        public void data()
        {
            string name;
            int age;
            double eng, math, sci, obt_mark, total_mark = 300, per;
            Console.WriteLine("enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the mark of english");
            eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("entre the math marks");
            math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the science mark");
            sci = Convert.ToDouble(Console.ReadLine());
            obt_mark = eng + math + sci;
            per = (obt_mark / total_mark) * 100;
            Console.WriteLine("--------------------------------\n\n");
            Console.WriteLine("name of student=" + name);
            Console.WriteLine("student age=" + age);
            Console.WriteLine("obtain marks=" + obt_mark);
            Console.WriteLine("percentage=" + per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Studentmarks i = new Studentmarks();
            i.data();
        }
    }
    class Usermethod
    {
        int x;
        int y;
        public void addition()
        {
          Console.WriteLine("addition="+(10+30));
            
        }
        public void Substraction(int x,int y)
        {
            this.x = x;
            this.y = y;
            showSubstraction();
        }
        void showSubstraction()
        {
            Console.WriteLine((x-y));
        }
        public float Multi()
        {
            return 1.2f * 3;
        }
        public void showMulti()
        {
            Console.WriteLine(this.Multi());
        }
        public double div(double x,double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Usermethod u = new Usermethod();
            u.addition();
            u.Substraction(6, 2);
            u.showMulti();

            double ans = u.div(4.5, 1.2);
            Console.WriteLine(ans);
        }
        
           
    }
    class Swapping
    {
        void swap( ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + " " + num2);
            Swapping s = new Swapping();
            s.swap(ref num1,ref num2);

            Console.WriteLine("after swapping");

            Console.WriteLine(num1 + " " + num2);

        }
    }
    class Methodoverloading
    {
        void show()
        {
            Console.WriteLine("show");
        }
        void show(int a,float b)
        {
            Console.WriteLine(a+" "+b);
        }
        void show(int x,int y)
        {
            Console.WriteLine(x+" "+y);
        }
        void show(int x,int y,int z)
        {
            Console.WriteLine((x+y+z)+" "+x+" "+y+" "+z);
        }
        static void Main(string[] args)
        {
            Methodoverloading h = new Methodoverloading();
            h.show(4, 5);
            h.show();
            h.show(3, 5, 6);
            h.show(4, 9.8f);
        }
    }
    class Calcovr
    {
        public void calculate(int x,int y,int z)
        {
            Console.WriteLine("add="+(x+y+z));
        }
        public void calculate(int x,int y)
        {
            Console.WriteLine("sub="+(x-y));
         
        }
        public void calculate(float x,float y)
        {
            Console.WriteLine("multi="+(x*y));
        }
        public void calculate(int x,float y)
        {
            Console.WriteLine("devide="+(x/y));
        }
        static void Main(string[] args)
        {
            Calcovr ca = new Calcovr();
            ca.calculate(5, 4, 8);
            ca.calculate(5, 4);
            ca.calculate(5.4f, 4.4f);
            ca.calculate(8, 2.6f);
        }

    }
    class Areaov
    {
        public void area(int a,int b)
        {
            Console.WriteLine("rectangle="+(a*b));
        }
        public void area(int a)
        {
            Console.WriteLine("square="+(a*a));

        }
        public void area(float PI,float b)
        {
            Console.WriteLine("circle="+(PI*b*b));

        }
        public void area(float a,int b,int h)
        {
            Console.WriteLine("triangle="+(a*b*h));
        }
        static void Main(string[] args)
        {
            Areaov ar = new Areaov();
            ar.area(8, 4);
            ar.area(4);
            ar.area(3.14f, 7);
            ar.area(0.5f, 8, 4);

        }
    }
    //constructor overload
    class Constov 
    {
        string carmodel;
        int caryear;
        public Constov(string model, int year)
        {
            carmodel = model;
            caryear = year;
        }
        public Constov(int year, string model)
        {
            carmodel = model;
            caryear = year;
        }
        static void Main(string[] args)
        {
            Constov ca = new Constov(1978, "bolero");
            Console.WriteLine("model:"+ca.carmodel);
            Console.WriteLine("year:"+ca.caryear);
        }
    }
    class statdemo2
    {
        int x = 10;
        static int y = 20;

        static void mydata()
        {
            statdemo2 d = new statdemo2();
            Console.WriteLine(d.x+" "+y);
        }
        void show()
        {
            
            Console.WriteLine(x+" "+y);
        }
        static void Main(string[] args)
        {
            statdemo2 st = new statdemo2();
            st.show();
            statdemo2.mydata();

        }
    }
    public static class STATOVL// overloading of static method
    {
        public static void calculate(int x, int y)
        {
            Console.WriteLine("addition:" + (x + y));
        }
        public static void calculate(float x, float y)
        {
            Console.WriteLine("multi:" + (x * y));
        }
        public static void  calculate(int x,float y)
        {
            Console.WriteLine("devide:"+(x/y));
        }
    }
    class statoverlo
    {
       
        static void Main(string[] args)
        {

            STATOVL.calculate(10, 20);
            STATOVL.calculate(4.4f, 2.1f);
            STATOVL.calculate(8, 2.2f);
        }
        
       
    }
    class sato//satic and non static variable
    {
        int x = 10;
        static int y = 5;

        static void addition()
        {
            sato h = new sato();
            Console.WriteLine("ADDITION:"+(h.x+y));
        }
        void devide()
        {
            Console.WriteLine("devide:"+(x/2));
        }
        static void Main(string[] args)//create another satic metod
        {
            sato.addition();
            sato j = new sato();
            j.devide();


        }
    }


    
    class Staticdemo
    {
        static int x;
        void get(int x)
        {
            Staticdemo.x = x;
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Staticdemo d = new Staticdemo();
            d.get(300);
            d.display();
        }
    }
    static class saticclassdemo
    {
        static int x = 100;
        
        static void Main(string[] args)
        {
          
            Console.WriteLine(x);
        }
    }
    class Test
    {
        static Test()
        {
            Console.WriteLine("this is static test");
        }
        public Test(int x)
        {
            Console.WriteLine("HI this parameter="+x);
        }
        static void Main(string[] args)
        {
            Test t = new Test(200);
            Test t2 = new Test(400);
        }
    }
    static class statdemo//static class example
    {
        static int x = 100;

        static void Main(string[] args)
        {
            Console.WriteLine(x);
        }
    }
    class Animal//access modifier
    {
        public int legs = 4;
        private int eye = 2;
        protected int ear = 2;
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine("hii"+a.legs+" "+a.eye+" "+a.ear);
        }
       
    }
    class accessmodifier: Animal
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.legs);
            /* Console.WriteLine(a.eye);*///error private
                                          //Console.WriteLine(a.ear);
            accessmodifier d = new accessmodifier();
            Console.WriteLine(d.ear);
        }
    }
    //encapsulation 
    class Employee5
    {
        private int id;
        private string name;//field
        private int salary;

        public int Id//property
        {
            get { return id; }//get method
            set { id = value; }//set method
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }

        }
    }
    class EmpInfo
    {
        static void Main(string[] args)
        {
            Employee5 e = new Employee5();
            e.Id = 200;
            e.Name = "Amit";
            e.Salary = 78000;

            Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);
        }
    }
    class Student12
    {
        private int id;
        private string name;
        private double per;

        public int ID
        {
            get;
            set;

        }
        public string Name
        {
            get;
            set;
        }
        public double Per
        {
            get;
            set;
        }
    }
    class xyz
    {
        static void Main(string[] args)
        {
            Student12 s = new Student12();
            s.ID = 3;
            s.Name = "yash";
            s.Per = 89.75;
            Console.WriteLine(s.ID + " " + s.Name + " " + s.Per);


        }

    }
    class StuD
    {
        private int id;
        private string name;
        private double per;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Per { get => per; set => per = value; }
    }
    class student14
    {
        static void Main(string[] args)
        {
            StuD s = new StuD();
            s.Id = 3;
            s.Name = "yash";
            s.Per = 89.75;
            Console.WriteLine(s.Id+ " " + s.Name + " " + s.Per);
        }
    }
    class Address
    {
        public int pincode;
        public string city;


        public Address(int pincode, string city)
        {
            this.pincode = pincode;
            this.city = city;
        }

        public void show()
        {
            Console.WriteLine(pincode + " " + city);
        }



    }
    class Person
    {
        int id;
        string name;
        Address adr;

        public Person(int id, String name, Address adr)
        {

            this.id = id;
            this.name = name;
            this.adr = adr;
        }

        void show()
        {
            Console.WriteLine(id + " " + name + " ");
            adr.show();
        }


        static void Main(string[] args)
        {
            //Address a = new Address(2034, "pune");
            //Person p = new Person(101, "nikhil", a);

            Person p = new Person(11, "nikhil", new Address(3043, "pune"));
            p.show();
        }

    }
    class Department
    {
        private int did;
        private string name;


        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            get{ return name; }
            set { name = value; }
        }
    }
    class Emp
    {
        private int id;
        private string name;
        private Department dept;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        static void Main(string[] args)
        {
            //Department d = new Department();
            //d.Did = 10;
            //d.Dname = "sales";

            //Emp e = new Emp();
            //e.Id = 400;
            //e.Name = "Nikita";
            //e.Dept = d;
            //Console.WriteLine(e.Id+" "+e.Name+" "+d.Did+" "+d.Dname);

            //Emp e = new Emp();
            //e.Id = 1;
            //e.Name = "omkar";
            //e.Dept = new Department();
            //e.Dept.Did = 101;
            //e.Dept.Dname = "HR";

            //Console.WriteLine(e.Id+" "+e.Name+" " + e.Dept.Did+" " + e.Dept.Dname);

            Emp e = new Emp();
            e.Id = 1;
            e.Name = "omkar";
            e.Dept = new Department();
            Department d = e.Dept;
            d.Did = 23;
            d.Dname = "HR";

            Console.WriteLine(e.Id+" "+e.Name+" "+d.Did+" "+d.Dname);



        }
    }
    class car2
    {
        private int car_model;
        private string car_name;
        private string car_color;
        private int price;

        public int Car_model
        {
            get { return car_model; }
            set { car_model = value; }
        }
        public string Car_name
        {
            get { return car_name; }
            set { car_name = value; }
        }
        public string Car_color
        {
            get { return car_color; }
            set { car_color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class car12
    {
        static void Main(string[] args)
        {
            car2 k = new car2();
            k.Car_model = 101;
            k.Car_name = "maruti";
            k.Car_color = "black";
            k.Price = 123354;

            Console.WriteLine(k.Car_model+" " + k.Car_name+" " + k.Car_color+" " + k.Price);

        }
    }
    class Mdate//employee contenment
    {
        private int dd;
        private int mm;
        private int yy;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }
    }
    class Mydepart
    {
        private int did;
        private string dname;

        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            get { return dname; }
            set {dname = value; }
        }
    }
    class Myemployee
    {
        private int id;
        private string name;
        Mydepart dept;
        Mdate dt;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Mydepart Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public Mdate Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        static void Main(string[] args)
        {
            Myemployee e = new Myemployee();
            e.Id = 200;
            e.Name = "Amit";
            e.Dept = new Mydepart();
            e.Dept.Did = 1;
            e.Dept.Dname = "sales";

            e.Dt = new Mdate();
            e.Dt.Dd = 2;
            e.Dt.Mm = 6;
            e.Dt.Yy = 2022;
            Console.WriteLine(e.Id+" "+e.Name+" "+e.Dept.Did+" "+e.Dept.Dname+" " + e.Dt.Dd+"/" + e.Dt.Mm+"/" + e.Dt.Yy);


        }

            
    }
    class Subengine
    {
        string cleanupdate;
        public Subengine(string cleanupdate)
        {
            this.cleanupdate = cleanupdate;

        }
        public void DisplaySubengine()
        {
            Console.WriteLine(cleanupdate);
        }
    }
    class Engine
    {
        string type;
        Subengine sub;

        public Engine(string type, Subengine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void DisplayEngine()
        {
            Console.WriteLine(type+" ");
            sub.DisplaySubengine();
        }

    }
    class C_ar
    {
        int modelno;
        string name;
        Engine e;

        C_ar(int modelno,string name, Engine e)
        {
            this.modelno = modelno;
            this.name = name;
            this. e = e;
        }
        void show()
        {
            Console.WriteLine(modelno+" "+name+" ");
            e.DisplayEngine();
        }
        static void Main(string[] args)
        {
            //Subengine sub = new Subengine("4 - june - 2022");
            //Engine e = new Engine("petrol", sub);
            //C_ar c = new C_ar(2334, "BMW", e);

            C_ar c = new C_ar(24343, "BMW", new Engine("PETROL", new Subengine("4 - june - 2022")))
;        }


    }
    class Mydate//SHIPMENT CODING
    {
        private int dd;
        private int mm;
        private int yy;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }

    }
    class Myorder
    {
        private int order_id;
        private string cust_name;
        private int price;
        private string city;

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
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    class Myshipment
    {
        private int ship_id;
        string order;
        Myorder ord;
        Mydate dt;

        public int Ship_id
        {
            get { return ship_id; }
            set { ship_id = value; }
        }
        public string Order
        {
            get { return order; }
            set { order = value; }
        }
        public Myorder Ord
        {
            get { return ord; }
            set { ord = value; }
        }
        public Mydate Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        static void Main(string[] args)
        {
            Myshipment m = new Myshipment();
            m.Ship_id = 101;
            m.Order = "yes";
            m.Ord = new Myorder();
            m.Ord.Order_id = 100;
            m.Ord.Cust_name = "akshay";
            m.Ord.Price = 250;
            m.Ord.City = "pune";

            m.Dt = new Mydate();
            m.Dt.Dd = 4;
            m.Dt.Mm = 5;
            m.Dt.Yy = 2022;

            Console.WriteLine(m.Ship_id+" "+m.Order+" "+m.Ord.Order_id+" " + m.Ord.Cust_name+" " + m.Ord.Price+" " + m.Ord.City+" " + m.Dt.Dd+"/" + m.Dt.Mm+"/" + m.Dt.Yy);    
        }

    }
    class Mypen
    {
        private int length;
        private string pen_color;
        private int price;
      

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Pen_color
        {
            get { return pen_color; }
            set { pen_color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class Mynib
    {
        private string nib_material;

        public string Nib_material
        {
            get { return nib_material; }
            set { nib_material = value; }
        }

    }
    class Mybag
    {
        private string bag_name;
        private string color;
        Mypen pen;
        Mynib nib;

        public string Bag_name
        {
            get { return bag_name;}
            set { bag_name = value;}
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Mypen Pen
        {
            get { return pen; }
            set { pen = value; }
        }
        public Mynib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        static void Main(string[] args)
        {
            Mybag b = new Mybag();
            b.Bag_name = "SKYBAG";
            b.Color = "BLACK";
            b.pen = new Mypen();
            b.Pen.Length = 5;
            b.Pen.Pen_color = "BLUE";
            b.Pen.Price = 10;

            b.Nib = new Mynib();
            b.Nib.Nib_material = "GOLD ALLOY";

            Console.WriteLine(b.Bag_name+" " + b.Color+" " + b.Pen.Length+" " + b.Pen.Pen_color+" " + b.Pen.Price+" " + b.Nib.Nib_material);
        }

    }
    //INHERITANCE------------
    class Mobile//MULTIPLE INHERITANCE
    {
        protected string meomary = "128";
    }
    class Apple:Mobile
    {
         protected string Camera = "3.5px";
        //void show()
        //{
        //    Console.WriteLine("Meomary"+meomary+" "+Camera);
        //}
        //static void Main(string[] args)
        //{
        //    Apple a = new Apple();
        //    a.show();

        //}
    }
    class Myiphonepro: Apple
    {
        string screen = "4.5inch";
        void display()
        {
            Console.WriteLine(meomary+" "+Camera+" "+screen);
        }
        static void Main(string[] args)
        {
            Myiphonepro P = new Myiphonepro();
            P.display();
        }
    }

    
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class Son : Parent
    {
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son C");
        }
    }
    public class Pro
    {
        public static void Main(string[] args)
        {
            Son s = new Son();
            s.DisplaySonC();
            s.DisplayParentsAB();
        }
    }
    public class Salary1
    {
        public float salary = 40000;
    }
    public class Programmer : Salary1
    {
        public float bonus = 10000;
    }
    class Inheritance
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

        }
    }
    public class Pet_animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
    public class Dog : Pet_animal
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }
    class Inheritance2
    {
        public static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
        }
    }
    class Laptop//herachical inheritance example
    {
        protected int price = 45000;
    }
    class Dell: Laptop
    {
        public void show()
        {
            price = 35000;

            Console.WriteLine("Dell="+price);
        }
    }
    class Hp: Laptop
    {
        public void display()
        {
            price = 56000;
            Console.WriteLine("Hp="+price);
        }
    }
    class Accer: Laptop
    {
        public void output()
        {
            price = 50000;
            Console.WriteLine("Accer="+price);
        }
    }
    class   Mylaptops
    {
        static void Main(string[] args)
        {
            Accer a = new Accer();
            a.output();
            Dell d = new Dell();
            d.show();
            Hp h = new Hp();
            h.display();
                
        }
    }
    public class Parent2//HERATICAL INHERITANCE
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class ChildC : Parent2
    {
        public void DisplayChildC()
        {
            Console.WriteLine("I am the child C");
        }
    }

    public class ChildD : Parent2
    {
        public void DisplayChildD()
        {
            Console.WriteLine("I am the child D");
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            ChildC cc = new ChildC();
            ChildD cd = new ChildD();

            cc.DisplayChildC();
            cc.DisplayParentsAB();  

            cd.DisplayChildD();
            cd.DisplayParentsAB();   
        }
    }
    class Animal12//use of base keyword
    {
        protected int legs = 0;

        public Animal12()
        {
            Console.WriteLine("Animal");
        }
        public Animal12(int x)
        {
            Console.WriteLine("x:"+x);
        }
        public void foo()
        {
            Console.WriteLine("parent");
        }

    }
    class Dog1 : Animal12
    {
        int legs = 4;

        public Dog1():base()
        {
            Console.WriteLine("Dog");
        }
        public Dog1(int x):base(x)
        {
            Console.WriteLine("My x child"+" "+x);
        }
        void show()
        {
            Console.WriteLine(legs+" "+base.legs);
            base.foo();
        }
        public void foo()
        {
            Console.WriteLine("child");
        }
        static void Main(string[] args)
        {
            Dog1 d = new Dog1();
                d.show();
                d.foo();
            Dog1 d1 = new Dog1(678);



        }
    }
    class Vehicle//overriding method classexample
    {
        public virtual void run()
        {
            Console.WriteLine("vehicle is running.....");
        }
    } 
    class CAR : Vehicle
    {
        public override void run()
        {
            Console.WriteLine("car is running........");
        }
    }
    class Truck:Vehicle
    {
        public override void run()
        {
            Console.WriteLine("Truck is running.....");
        }
    }
    class Overridingdemo
    {
        static void Main(string[] args)
        {
            //CAR c = new CAR();
            //c.run();
            //Vehicle v = new CAR();
            Truck t = new Truck();
                t.run();




        }
    }

    class Printer//used of sealed
    {
        public virtual void show()
        {
            Console.WriteLine("show");
        }
    }
    class Laser: Printer
    {
        /*sealed*/ public override void show()
        {
            Console.WriteLine("laser");
        }
    }
    class Officejet: Laser
    {
        public override void show()
        {
            Console.WriteLine("my");
        }

    }
    class Myclass
    {
        static void Main(string[] args)
        {
            Laser l = new Laser();
            l.show();
            Officejet f = new Officejet();
            f.show();
            Printer p = new Printer();
            p.show();


        }
    }
    class parent//practice method override
    {
        public virtual void print()

        {

            Console.WriteLine("This is method of PARENT class");
        }
    }
    class child:parent
    {
        public override void print()

        {
            //base.print();
            Console.WriteLine("This is method of CHILD class");
        }
    }
    class pro
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.print();
        }
    }


























}
