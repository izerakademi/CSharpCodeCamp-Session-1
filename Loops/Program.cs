using System;

namespace Loops
{
    class Program
    {

        static void Q1()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + ": Hello World");
            }
        }
        static void Q2()
        {
            Console.Write("Enter Text : ");
            string text = Console.ReadLine();
            Console.Write("How many times ? : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Q3()
        {
            Console.Write("Enter Start : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter End   : ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Increase : ");
            int increase = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i+=increase)
            {
                Console.WriteLine(i);
            }
        }

        static void Q4()
        {
            int counter = 0;
            for (int i = 1; i <=100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine("Quantity : " + counter);
        }

        static void Q5()
        {
            int counter = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                i++;
            }
            Console.WriteLine("Quantity : " + counter);
        }

        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            Q5();
            Console.WriteLine("Loops");
            Console.WriteLine("**************");
            Console.WriteLine("For Loops");
            Console.WriteLine("**************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************");
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************");
            Console.WriteLine("While Loops");
            Console.WriteLine("**************");

            int number = 0;
            while (number<7)
            {
                Console.WriteLine(number);
                number = number + 1;
                //number++;                
            }

            Console.WriteLine("**************");
            Console.WriteLine("Do While Loops");
            Console.WriteLine("**************");
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 7);

            Console.WriteLine("**************");
            Console.WriteLine("Break Keyword");
            Console.WriteLine("**************");
            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("**************");
            int c = 0;
            while (c < 7)
            {
                if (c == 4)
                {
                    break;
                }
                Console.WriteLine(c);
                c++;
            }

            Console.WriteLine("**************");
            Console.WriteLine("Continue Keyword");
            Console.WriteLine("**************");
            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
