using System;

namespace Learning_Constants
{
    
    //Constants are immutable values which are known at compile time and do not change for the life of the program.

    class Program
    {

        // constants as fields
        const double PI = 3.14159265359;
        //store two values as integers
        const int weeks = 52, month = 12;
        const string birthday = "06-09-1985";

        static void Main(string[] args)
        {

            Console.WriteLine("My Birthday is always going to be: {0}", birthday);
            Console.ReadKey();
            

        }
    }
}
