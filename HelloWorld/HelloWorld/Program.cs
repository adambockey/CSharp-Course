using System;
using HelloWorld;

namespace HelloWorld
{
    public class Program
    {
        // Entry point of our program

        // variable type . name . value
        int iAmANumber = 5;
        // integers store whole numbers up from -2,147,483,648 to 2,147,483,647
        float pi = 3.1415f;
        // floats are numbers with decimals
        // requires an "f" at the end of the number to define
        // store decimals between 1.5 x 10 ^~45 to 3.4 x 10^38
        // 7-digit precision
        double thisIsADouble = 1.123456789012345;
        // stores decimals up to 15-digit precision
        decimal thisIsADecimal = 1.1234567890123456789012345678M;
        // stores decimals up to 28-digit precision
        // requires an "M" at the end of the number to define
        bool isGPSEnabled = true;
        // bools are true/false values, switches between the two
        string myName = "Denis";
        // strings are text, requires " " to define
        char at = '@';
        // char stores a single character, requires ' ' to define
        sbyte thisBytes = 120;
        // shortbyte stores between -128 & 127
        short thisIsShort = 30000;
        // short stores between -32767 to 32767
        long thisIsLong = 456423156464123;
        // long store whole numbers between +/- 9,223,327,036,854,775,808

        // WHEN TO USE VARIABLES
        // float - mostly in graphics library (balanced performance/accuracy
        // double - mostly in real world values (high performance/less accuracy)
        // decimal - mostly for financial applications (less performance/most accuracy)


        // the more variables declared, the more memory the application will require

        static void Main(string[] args)
        {

            // Creating a variable inside of a method
            // The variable will only be usable inside that method
            string insideVariable = "Only usable within this method";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Adam!");
            Console.WriteLine(insideVariable);
            Console.Read();

            
        }
    }
}
