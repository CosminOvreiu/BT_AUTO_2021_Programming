﻿using System;
using System.Collections.Generic;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        public enum Browsers
        {
            Chrome,
            Firefox,
            Edge

        }

        static void Main(string[] args)
        {
            //Course01(args);
            // Course02(args);
            //Course03(args);
            //Course04();
            //Course05();
            //Course06();
            //Course07();
            Course08();


        }

        

        static void Course01(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;


            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");
            Console.WriteLine(6 + 2);
            Console.WriteLine("6 + 2");

            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;
            char ch = 'd'; // '1' !=1

            string myString = "Ana are mere si pere";
            string result = myString + " si struguri";
            Console.WriteLine(result);



            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5; //x = x + 5;
            // x++ <=> x = x + 1
            // ++x <=> x = x + 1
            Console.WriteLine(++x);
            Console.WriteLine((x < a));


            int number = 8;
            Console.WriteLine("Number tested is " + number);

            if (number >= 0)
            {
                Console.WriteLine("Number is positive!");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd number!");
            }



            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed!");
                }
                else
                {
                    Console.WriteLine("Student passed!");
                }
            }
            else
            {
                Console.WriteLine("Grade is invalid");
            }

            // One line if / else
            String message = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(message);




            if (number == 1)
            {
                Console.WriteLine("Mondady");
            }
            if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid day!");
                        break;
                    }


            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }


            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
            while (counter <= MAX_NUMBER);


            for (counter = 0; counter <= MAX_NUMBER; counter++)
            {
                //Console.WriteLine("Current number is: " + counter);
                Console.WriteLine("Current number is: {0}", counter);
            }

            foreach (string argument in args)
            {
                Console.WriteLine("The argument is: {0}", argument);
            }




            foreach (string yr in args)
            {

                int febDays = 28;
                int year = int.Parse(yr);


                /*if (year % 4 == 0)
                {
                    if (year % 100 == 0 && year % 400 ! = 0)
                    {
                        febDays = 29;
                    }
                    if (year % 100 == 0 && year % 400 == 0)
                    {
                        febDays = 28;
                    }
                    if (year % 100 != 0)
                    {
                        febDays = 29;
                    }
                }*/
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("Year is out of valid bounds (1900-2016)");
                }
                else
                {
                    if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        febDays = 28;
                    }

                    Console.WriteLine("February has {0} days", febDays);
                }

            }


        }

        static void Course02(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2; // c2 will be null !!!
            c1.SetRadius(10);
            /* double area = c1.GetArea();*/
            /* Console.WriteLine(c1.GetArea());*/
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.SetRadius(5);
            /*Console.WriteLine(c3.GetArea());*/
            c3.PrintCircle();
            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));
                Square s = new Square();
                s.SetSide(Double.Parse(p));
                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(p), Double.Parse(p));
                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();

            }

            Person p1 = new Person();
            p1.SetName("Alex");
            p1.SetSex('m');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();

        }

        static void Course03(string[] args)

      
       







        {
            //ComputeConversion(args);
            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "17d");
            //Console.WriteLine(ConcatenateStrings(args));
            Random rnd = new Random();
            GuessNumber(rnd.Next(1,1000));
        }


        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(14, 22);
            DrawShapeOutline2(14, 22);
            Console.WriteLine();
            DrawShapeCorners(10, 13);
            Console.WriteLine();
            DrawShapeCorners2(10, 13);

            Circle c1 = new Circle();  //instantiate c1 with default (no params) constructor
            Circle c2 = new Circle(10); // instantiate c2 with constructor having 1 double parameter
            c1.PrintCircle(); 
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Alex", 'm', new string[] { "Romanian" }, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExample se = new StructExample();
            StructExample.MyStruct myStruct = new StructExample.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());


            StructExample.Rectangle3d r2 = new StructExample.Rectangle3d();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());



        }


        static void Course05()
        {
            DrawShapeOutLine(5);
            DrawShapeOutline(10, 5);
            DrawShapeCorners(6);
            DrawFullShape(7);

            Circle c = new Circle(4);
            Object o = new object();
            c.Draw();
            Triangle t1 = new Triangle(5, 7, 9);
            t1.Draw();
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(2, 7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(c.ToString());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(s1.ToString());

            Teacher teacher1 = new Teacher("Programming", "UPB", 2000, "Gigel Programatoru'", 'm');
            teacher1.PrintTeacher();

            Student stundent1 = new Student("AN 1", true, true, "Andreea A", 'f');
            stundent1.PrintStudent();
        }

        private static void Course06()
        {
            Car c1 = new Car(true, 20, 90);
            Car c2 = new Car(false, 0, -90);
            c1.Start();
            c1.Accelerate();
            c1.TurnLeft();
            c1.TurnRight();

            Console.WriteLine(Car.ConvertHpToKw(150));

            Rectangle r1 = new Rectangle(3, 4);
            r1.PrintRectangle();

            r1.SetLength(10);
            r1.PrintRectangle();

            c2.Start();
            c2.GearUp();
            c2.Accelerate(20);
            c2.Steer(20);
            c2.Accelerate(10);
            c2.TurnLeft();
            c2.GearUp();
            c2.Accelerate();
            c2.PrintCar();

        }

        private static void Course07()
        {
            Square s1 = new Square();
            Rectangle r1 = new Rectangle();
            Shape sh1 = new Shape();

            //polymorphism
            IShape s2 = new Square();
            IShape r2 = new Rectangle();
            IShape sh2 = new Shape();

            List<string> lista = new List<string>();
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(s2);
            shapeList.Add(r2);
            shapeList.Add(sh2);
            shapeList.Add(s1);

            s1.Draw();
            s2.Draw();
            s2.State();

            s1.PrintSquare();
            ((Square)s2).PrintSquare();

            // example of using polymorphism
            Shape sh3;
            string type = "rectangle";

            switch (type)
            {
                case "square":
                    {
                        sh3 = new Square();
                        break;
                    }
                case "rectangle":
                    {
                        sh3 = new Rectangle();
                        break;
                    }
                default:
                    {
                        sh3 = new Shape();
                        break;
                    }

            }
            sh3.Draw();
            sh3.Erase();

            // Without polymorphism - do not do this!!!  
            Square s3 = new Square();
            Rectangle r3 = new Rectangle();
            Shape sh4 = new Shape();

            switch (type)
            {
                case "square":
                    {
                        s3.Draw();
                        break;
                    }
                case "rectangle":
                    {
                        r3.Draw();
                        break;
                    }
                default:
                    {
                        sh4.Draw();
                        break;
                    }
            }

            switch (type)
            {
                case "square":
                    {
                        s3.Erase();
                        break;
                    }
                case "rectangle":
                    {
                        r3.Erase();
                        break;
                    }
                default:
                    {
                        sh4.Erase();
                        break;
                    }
            }

            IIntf ob1 = new MyParticularShape();
            IClass ob2 = new MyParticularShape();
            ob1.Print();
            ob2.Print();

            PartialClass pc = new PartialClass();
            pc.Method1();
            pc.Method2();


        }

        private static void Course08()
        {
            Person p = new Person("Ionel", "Ionescu", "Str. Margelelor nr 2", "Vartop", "RO");
            Employee e = new Employee("Makaduku", "Makao", "-", "Ananarivo", "Madagascar", 1500);
            PartTimeEmployee pe = new PartTimeEmployee("Andrei", "Antonescu", "Str. Unirii nr 2", "Iasi", "RO", 1000);

            Person.PrintPersonStatic(p);
            Employee.PrintPersonStatic(e);
            Employee.PrintPersonStatic(pe);

            p.PrintPerson();

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            Shape[] shapes = new Shape[2] { s1, r1 };

            foreach (int x in intArray)
            {
                Console.WriteLine(x);
            }
            for (int i=0; i < intArray.Length; i ++)
            {
                Console.WriteLine(intArray[i]);
            }

            List<string> myList = new List<string>();
            myList.Add("Alex");
            myList.Add("Andreea");
            myList.Add("Andrei");

            Console.WriteLine(myList.IndexOf("Alex"));
            Console.WriteLine(myList[0]);

            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i< myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            String stringDemo = "ana are mere"; //a:3, n:1, r:2, e:3, m:1
            Dictionary<char, int> characterFreaq = new Dictionary<char, int>();
            foreach(char c in stringDemo)
            {
                if (characterFreaq.ContainsKey(c))
                {
                    characterFreaq[c] = characterFreaq[c] + 1;
                }
                else
                {
                    characterFreaq.Add(c, 1);
                }
            }

            foreach(char key in characterFreaq.Keys)
            {
                Console.WriteLine("{0}:{1}", key, characterFreaq[key]);
            }
            foreach(KeyValuePair<char,int> kvp in characterFreaq)
            {
                Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
            }

            //SortedList<int, string> listSorted = new SortedList<int, string>();
            var listSorted = new SortedList<int, string>();
            listSorted.Add(6, "abc");
            listSorted.Add(10, "abcd");
            listSorted.Add(1, "xyz");

            foreach(int key in listSorted.Keys)
            {
                Console.WriteLine("{0}: {1}", key, listSorted[key]);
            }

            //HashSet<int> hs = new HashSet<int>(intArray);
            var hs = new HashSet<int>(intArray);
            hs.Add(1);
            foreach(int i in hs)
            {
                Console.WriteLine(i);
            }

            var myQueue = new Queue<int>();
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(100);
            myQueue.Enqueue(1);
            int value = myQueue.Dequeue(); //returns 2
            Console.WriteLine("Queue elements: {0}", myQueue.Count);


            var myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(100);
            myStack.Push(1);
            int stackVal = myStack.Pop(); //returns 1
            Console.WriteLine("Stack elements: {0}", myStack.Count);
            Console.WriteLine(Browsers.Firefox);


        }





        public static void DrawShapeOutline(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) /// this will print a single line with * counting width
                {
                    if (j == 0 || j==height-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i ==0 || i ==width-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

        }

        public static void DrawShapeOutLine(int l)
        {
            DrawShapeOutline(l, l);
        }


        public static void DrawShapeCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) 
                {
                    if( (j==0 && i==0) || (j==0 && i==width-1)  || (j==height-1 && i==0)  || (j == height - 1 && i==width-1) )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeCorners(int l)
        {
            DrawShapeCorners(l, l);
        }

        public static void DrawFullShape(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) /// this will print a single line with * counting width
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }      
        }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l, l);
        }

        public static void DrawFullShape2(int width, int height)
        {
            String s = "";
            for (int i = 0; i < width; i++) /// this will print a single line with * counting width
             {
                s += "*";
             }
             for (int j = 0; j < height; j++)
            {
                Console.WriteLine(s);
            }
        }


        public static void DrawShapeOutline2(int width, int height)
        {
            String s = "";  //*****
            String s1 = "";  // *    *
            for (int i = 0; i < width; i++) /// this will print a single line with * counting width
            {
                s += "*";
                if (i==0 || i==width-1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }
            }

            for (int j = 0; j < height; j++)
            {
                if(j==0 || j == height - 1)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(s1);
                }
               
            }
        }


        public static void DrawShapeCorners2(int width, int height)
        {
            String s = "";  //     
            String s1 = "";  // *    *
            for (int i = 0; i < width; i++) /// this will print a single line with * counting width
            {
                s += " ";
                if (i == 0 || i == width - 1)
                {
                    s1 += "*";
                }
                else
                {
                    s1 += " ";
                }
            }

            for (int j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1)
                {
                    Console.WriteLine(s1);
                }
                else
                {
                    Console.WriteLine(s);
                }

            }
        }


        static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }



        static int TestValue(int testVal, int target)
        {
            
            if (testVal < target)
            {
                Console.WriteLine("Number to be guess is higher!");
                return -1;
            }
            if (testVal > target)
            {
                Console.WriteLine("Number to be guess is lower!");
                return 1;
            }
            Console.WriteLine("Bazinga! This is the number!!");
            return 0;

        }


        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) !=0);
        }




        static Shape GetShape(int x, int y, double a, char t, String s)
        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";

            foreach (string s in args)
            {
                returnString += s; // returnString = returnString + s;
            }
            return returnString;
        }



        static void ComputeConversion(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The application receives only 3 arameters: amount, currency, exchange rate");
            }

            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }
        }


        static void CurrencyCalculator(double amount, string currency, double conversionRate)
        {
            Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);

        }

       



    }
}