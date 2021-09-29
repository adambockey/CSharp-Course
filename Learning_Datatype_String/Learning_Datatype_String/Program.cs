using System;

namespace Learning_Datatype_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // String is a Class and not a "primitive" Datatype.
            // It's still a Datatype, it contains multiple Characters.

            string myName = "Adam";
            string message = "My name is " + myName;

            //more concatination with + :)
            //Console.WriteLine("My name is: " + myName);

            //Capitalized S is a class itself and can be called on for methods
            //Lowercase s for string is a class within the System namespace

            //store a new string with conversion to upper
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            //store a new string with conversion to lower
            string lowerMessage = message.ToLower();
            Console.WriteLine(lowerMessage);



            Console.WriteLine(message);
            Console.Read();

        }
    }
}
