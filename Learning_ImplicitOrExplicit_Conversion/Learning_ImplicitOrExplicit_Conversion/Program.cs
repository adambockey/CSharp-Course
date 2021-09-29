using System;


namespace Learning_ImplicitOrExplicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            //variable = other variable
            int num = 12345678;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;


            double myDouble = 13.37; //create a double variable and initialize it
            int myInt; //create an integer variable but do not initialize it


            //cast a double to an int using explicit coversion
            //**Does not round, eliminates excess
            //variable = (cast)oldVariable;
            myInt = (int)myDouble; //set myInt equal to myDouble cast as int
            Console.WriteLine(myInt);
            Console.Read();

            //typeConversion
            string myString = myDouble.ToString(); //converts to string with surrounding quotations
            num.ToString(); //shortened conversion to a defined variable
            string floatString = myFloat.ToString();
            Console.WriteLine("Your float is {0}", floatString);

            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);

            /*
             * Implicit conversion outputs variables that meet the requirements of the next variable
             * Explicit conversion casts output of variables that do not meet the requirements of the first variable
             */

        }
    }
}
