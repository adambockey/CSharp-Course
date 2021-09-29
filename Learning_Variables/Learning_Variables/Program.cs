using System;

namespace Learning_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Variable can be declared, but never assigned.

            //declaring a variable
            int num1;
            //with no value assigned the variable is not initialized

            num1 = 13;
            //assigning a value and initializing the variable

            int num2 = 23;
            //declaring and initializing the variable in the same line

            //declaring multiple variables in one line
            int num3, num4, num5;

            //changing the value of the variable BEFORE performing the math
            num2 = 100;
            //declaring and initializing a new varibale using two previous variables
            int sum = num1 + num2;

            //changing the value of the variable AFTER performing the math
            num2 = 100;

            //using concatination
            //the concept of adding strings & numbers together is referred to as concatination
            Console.WriteLine("Number One is " + num1);
            Console.WriteLine("Number Two is " + num2);
            Console.WriteLine("Number One: " + num1 + " + Number Two: " + num2 + " is " + sum);
            // the + in a string represents adding another function, not performing the math.

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            //Shows double precision
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            //Shows float precision
            Console.WriteLine("f1/f2 is " + fDiv);

            long myLongNum = 123456789012345678;
            int myLongInt = 1234567890;

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 as double: " + dIDiv);

            //will not work without a cast
            //int dIDivInt = d1 / num1;
            //Console.WriteLine("d1/num1 as int: ");

            //Console.WriteLine(sum);
            Console.Read();
        }
    }
}
