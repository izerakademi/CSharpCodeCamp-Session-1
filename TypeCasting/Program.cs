using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Casting");
            Console.WriteLine("********************");
            Console.WriteLine("Implicit Casting");
            Console.WriteLine("********************");

            int number = 9;
            double currentNumber = number;

            Console.WriteLine("********************");
            Console.WriteLine("Explicit Casting");
            Console.WriteLine("********************");

            double doubleNumber = 9.75;
            int integerNumber = (int)doubleNumber;

            Console.WriteLine("Double Number : " + doubleNumber);
            Console.WriteLine("Integer Number: " + integerNumber);

            Console.WriteLine("********************");
            Console.WriteLine("Type Conversions Methods");
            Console.WriteLine("********************");
            integerNumber = 10;
            doubleNumber = 5.20;
            bool isCorrect = true;

            Console.WriteLine(Convert.ToString(integerNumber));
            Console.WriteLine(Convert.ToDouble(integerNumber));
            Console.WriteLine(Convert.ToInt32(doubleNumber));
            Console.WriteLine(Convert.ToString(isCorrect));
        }
    }
}
