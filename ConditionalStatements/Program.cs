using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Q1()
        {
            Console.Write("Enter Number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 3: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double average = (number1 + number2 + number3) / 3;
            Console.Write("Average : " + average);
            if(average >= 65)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        static void Q2()
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }

        static void Q3()
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>=0 && number <= 100)
            {
                Console.WriteLine("Correct Number");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }
        }

        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            Q3();
            Console.WriteLine("ConditionalStatements");

            int number = -10;

            if (number == 0)
            {
                Console.WriteLine("Number is equal to zero");
            }

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }

            if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }

            if (number == 0)
            {
                Console.WriteLine("Number is equal to zero");
            }
            else if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }


            int day = 15;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Invalid Input Value");
                    break;
            }

            Console.WriteLine("Ternary Operator");
            number = -10;
            // variable = (condition) ? expressionTrue : expressionFalse
            string result = (number > 0) ? "Number is positive" : "Number is negative";
            Console.WriteLine(result);
        }
    }
}
