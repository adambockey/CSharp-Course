using System;

namespace Learning_Value_vs_Reference_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Datatypes and Reference Datatypes");

            //A VALUE datatype when declared and assigned, holds the value in it's own memory space.
            //VALUE datatypes use a "Heap" to store the value.
            //VALUE datatypes examples are;
            int integerType = 1;
            byte byteType = 1;
            //enum enumType {spring, summer, fall, winter }
            float floatType = 1.0f;
            long longType = 1;
            short shortType = 1;
            sbyte sbyteType = 1;
            double doubleType = 1;
            char characterType = '@';
            bool boolType = true;
            decimal decimalType = 1.0M;

            //A REFERENCE datatype stores the memory location of the data, as opposed to storing the actual value in memory.
            //REFERENCE variables store the memory location of the data and not the data directly.
            //REFERENCE datatype examples are;
            //Copying the REFERENCE type of data will copy the memory address, multiple variables can be pointed at the same data.
            //REFERENCE datatypes should be used more that VALUE datatypes when possible. 
            string stringType = "This is a string";
            // Declare and initialize an array.
            int[,] arrayType = new int[5, 10];
            Console.WriteLine("The array has {0} dimensions.", arrayType.Rank);
        }
        //class classType { };
           

        }

    }
