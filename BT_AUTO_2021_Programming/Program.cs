using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;



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

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            bool myBoolean = true;
            char ch = 'd'; // '1' !=1

            string myString = "Ana are mere si pere";
            string result = myString + " si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            ConsoleWriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5; //x=x+5;










            Console.WriteLine(typeof(int).IsPrimitive);






        }
    }
}