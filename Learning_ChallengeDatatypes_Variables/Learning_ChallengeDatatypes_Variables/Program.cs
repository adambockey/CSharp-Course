using System;

namespace Learning_ChallengeDatatypes_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a variable of each datatype
            //initialize each with a working value
            byte _myByte = 255;
            sbyte _mySByte = -128;
            int _myInt = 2;
            uint _myUInt = 3;
            short _myShort = -32768;
            ushort _myUShort = 65535;
            long _mylong = 6;
            ulong _myUlong = 7;
            float _myFloat = 8.0f;
            double _myDouble = 9;
            char _myChar = '@';
            bool _myBool = true;
            string _myString = "test";
            decimal _myDecimal = 10.0M;

            //create two values of type string
            //the first one should read "I control text"
            string _firstString = "I control Text";
            //the second should be a whole number, parse the whole number to convert to integer
            string _secondString = "512";
            int _parsedString = Int32.Parse(_secondString);
            Console.WriteLine(_firstString);
            Console.WriteLine("Your parsed string is {0}", _parsedString);

            //write each of the variables to console
            Console.WriteLine(_myByte);
            Console.WriteLine(_mySByte);
            Console.WriteLine(_myInt);
            Console.WriteLine(_myUInt);
            Console.WriteLine(_myShort);
            Console.WriteLine(_myUShort);
            Console.WriteLine(_mylong);
            Console.WriteLine(_myUlong);
            Console.WriteLine(_myFloat);
            Console.WriteLine(_myDouble);
            Console.WriteLine(_myChar);
            Console.WriteLine(_myBool);
            Console.WriteLine(_myString);
            Console.WriteLine(_myDecimal);

            Console.WriteLine("Press any Key to continue...");
            Console.ReadKey();
        }
    }
}
