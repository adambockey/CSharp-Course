using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Learning_ConsoleMethod
{
    class Program
        //Namespaces and Classes should have EachWordCapitalized and be named to explain their function
        //Example Namespace "CheeseBurger"
        //Example Classes "SesameBun, BeefPatty, SlicedTomato
    {
        ///<summary>
        ///Console is the CLASS, Write is the METHOD, ("Hello World!") is a STRING DATATYPE used by method to print text to the screen.
        ///The class Console is accessed by the "using" tag at the very top, it tells our program to use that namespace, which contains the class CONSOLE and all of it's methods (kind of) become available.
        ///</summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            * ASCII is "American Standard Code for Information Interchange
            * check out ascii-code.com for table/conversions/values
            * example: the character A in uppercase is 65 in ASCII, 01000001 in Binary, 41 in HEX, 101 in OCT, 
            */

            //Console.Write("Using Console.Write, the text is printed on the SAME LINE"); //prints and keeps the cursor on the same line
            //Console.WriteLine("Using Console.WriteLine, the text is printed on the NEXT LINE"); //prints and puts the cursor on the next line
            //Console.Read(); //takes a single input of type string and returns the ASCII value of that input (INTEGER VALUE)
            //Console.ReadLine(); //takes a string or integer value input and returns it as the output value
            //Console.ReadKey(); //takes a single input of type string and returns the key info

            //Console.WriteLine("Enter a string and press Enter...");
            //string readInput = Console.ReadLine();
            //Console.WriteLine("You have entered {0}", readInput);

            //Console.WriteLine("Enter a new string and press Enter...");
            //int asciiValue = Console.Read();
            //Console.WriteLine("You have entered {0}", asciiValue);
            //Console.ReadKey();

            //Write a program that tells you the ASCII value of charcters entered

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear(); //Clears the console buffer and corresponding window of display information
            Console.WriteLine(" ");
            Console.WriteLine("ASCII Converter");
            Console.WriteLine("Enter a single keystroke to convert to ASCII...");
            int asciiReturn = Console.Read();
            Console.ForegroundColor = ConsoleColor.Red; // Changes text to red colour
            Console.WriteLine("Your ASCII Value is {0}", asciiReturn);

            //Removing "using" namespace references at the top will prevent the Console class from working
            //Removing all instances of "Console" will grey out the using to show that it is no longer required

        }
    }
}
