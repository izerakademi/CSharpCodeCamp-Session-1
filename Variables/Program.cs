using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine("********************");
            Console.WriteLine("Integer Data Types");
            Console.WriteLine("********************");
            sbyte number = 4;   // -128 to 127
            byte number1 = 10;  // 0 to 255	
            short number2 = 20; // -32,768 to 32,767
            int number3 = 15;   // -2,147,483,648 to 2,147,483,647
            long number4 = 200; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ushort number5 = 12; // 0 to 65,535	
            uint number6 = 30;   //  0 to 4,294,967,295
            ulong number7 = 60;  //  0 to 18,446,744,073,709,551,615	

            // CTRL + K + D

            Console.WriteLine("Sbyte : " + number);
            Console.WriteLine("Byte  : " + number1);
            Console.WriteLine("Short : " + number2);
            Console.WriteLine("Int   : " + number3);
            Console.WriteLine("Long  : " + number4);
            Console.WriteLine("UShort: " + number5);
            Console.WriteLine("UInt  : " + number6);
            Console.WriteLine("ULong : " + number7);

            int age = 21;
            Console.WriteLine("Age : " + age);


            Console.WriteLine("********************");
            Console.WriteLine("Floating Data Types");
            Console.WriteLine("********************");

            float floatingNumber = 10.2f; // 32-bit single-precision floating point type
            double doubleNumber = 10.2; // 64-bit double-precision floating point type	
            decimal decimalNumber = 10.4m; // 128-bit precise decimal values with 28-29 significant digits	

            Console.WriteLine("Floating Number : " + floatingNumber);
            Console.WriteLine("Double Number   : " + doubleNumber);
            Console.WriteLine("Decimal Number  : " + decimalNumber);

            Console.WriteLine("********************");
            Console.WriteLine("Logical Data Type");
            Console.WriteLine("********************");
            bool isCorrect = true;
            Console.WriteLine("Is correct : " + isCorrect);
            isCorrect = false;
            Console.WriteLine("Is correct : " + isCorrect);

            Console.WriteLine("********************");
            Console.WriteLine("Character Data Type");
            Console.WriteLine("********************");
            char character = 'A';
            Console.WriteLine("Character : " + character);

            Console.WriteLine("********************");
            Console.WriteLine("Constants");
            Console.WriteLine("********************");

            const int identityNumber = 21233352;
            Console.WriteLine("Constant : "+ identityNumber);

            Console.WriteLine("********************");
            Console.WriteLine("Strings");
            Console.WriteLine("********************");
            string firstName = "Ali";
            string lastName = "Solmaz";
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
