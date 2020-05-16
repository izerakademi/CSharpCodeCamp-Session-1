using System;

namespace UserInput
{
    class Program
    {

        static void Q1()
        {
            Console.Write("Firstname : ");
            string firstName = Console.ReadLine();
            Console.Write("Lastname : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", firstName, lastName);
        }

        static void Q2()
        {
            Console.Write("First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            int sub = number1 - number2;
            int mul = number1 * number2;
            double div = number1 / (double)number2;
            Console.WriteLine("{0} and {1} of sum : {2} ", number1, number2, sum);
            Console.WriteLine("{0} and {1} of sub : {2} ", number1, number2, sub);
            Console.WriteLine("{0} and {1} of mul : {2} ", number1, number2, mul);
            Console.WriteLine("{0} and {1} of div : {2} ", number1, number2, div);
        }

        static void Q3()
        {
            Console.Write("Enter Weight : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height : ");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = weight * height;
            int env = 2 * (weight + height);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Env  : " + env);
        }

        static void Q4()
        {
            const double pi = 3.14;
            Console.Write("Enter Radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = pi * radius * radius;
            double env = 2 * pi * radius;
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Env  : " + env);
        }

        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            Q4();


            /*
            Console.WriteLine("User Input");
            Console.WriteLine("Enter Username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Username : " + username);

            Console.WriteLine("Enter Your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + age);
            */

        }
    }
}
