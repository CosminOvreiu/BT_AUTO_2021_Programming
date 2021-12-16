using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BT_AUTO_2021_Programming
{
    class HommmeWork
    {
        public static void Main(string[] args)
        {
            //Problem #1 Implement an arithmetic calculator that takes 3 arguments: the first number, the operation, the second number.

            static void Calculator(string[] args)
            {
                args = new string[] { "5", "+", "5" };

                if (args.Length == 3)
                {

                    float a = float.Parse(args[0]);

                    float b = float.Parse(args[2]);

                    string op = args[1];

                    // implement calculator logic here

                    var result = new DataTable().Compute(a + op + b, "") + "";


                    Console.WriteLine("Result is: " + result);

                }
                else
                {

                    Console.WriteLine("3 args are needed!");

                }
            }





            //Problem #2 Calculate the sum of the first 100 numbers higher than 0

            static void Calulate()
            {
                int sum = 1;
                for (int x = 1; x <= 100; x++)
                {
                    sum += x;
                    Console.WriteLine("The sum of these two numbers is {0} ", sum);
                }
            }





            //Problem #3 Check if a number is palindrome(e.g.palindrome 1221, 34143)

            static void Palidrom()
            {
                int num, rem, sum = 0, temp;
                //clrscr();    
                Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
                Console.Write("\n Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                temp = num;
                while (num > 0)
                {
                    rem = num % 10; //for getting remainder by dividing with 10    
                    num = num / 10; //for getting quotient by dividing with 10    
                    sum = sum * 10 + rem;
                    /*multiplying the sum with 10 and adding  
                    remainder*/
                }
                Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
                if (temp == sum) //checking whether the reversed number is equal to entered number    
                {
                    Console.WriteLine("\n Number is Palindrome \n\n");
                }
                else
                {
                    Console.WriteLine("\n Number is not a palindrome \n\n");
                }
            }


            //Problem #4 Display all the prime numbers lower than a given number

            static void PrimeNr()
            {
                int count = 0;
                Console.WriteLine("Enter Number: ");
                int Prime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prime Numbers between 1 to " + Prime + " is:");
                for (int i = 1; i < Prime; i++)
                {
                    count = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                count = 1;
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            Console.Write(i + "  ");
                        }
                    }
                }
            }

            Calculator(args);
            Calulate();
            Palidrom();
            PrimeNr();
        }




    }
}
