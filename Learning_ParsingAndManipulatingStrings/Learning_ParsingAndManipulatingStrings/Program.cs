using System;

namespace Learning_ParsingAndManipulatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            string myThirdString = "15.5";
            //when parsing ensure the string can only be populated with numbers or an exception will occur
            int num1 = Int32.Parse(myString); //parses first string to 32-bit integer
            int num2 = Int32.Parse(mySecondString); // parses second string to 32-bit integer

            //concatenated strings, will not do math
            string result = myString + mySecondString;

            int resultInt = num1 + num2; //adds both integer results after conversion to integer from string           

            double _d1 = Double.Parse(myString);
            double _d2 = Double.Parse(myThirdString);

            double resultDouble = _d1 + _d2;

            Console.WriteLine("concatenated string 15 + string 13 = {0}", result);
            Console.WriteLine("strings 15 and string 13 parsed to Int32 then added via int variable = {0}", resultInt);
            Console.WriteLine("strings 15 and 13.5 parsed to double then added via double variable = {0}", resultDouble);
            Console.Read();
            Console.Clear();

            int age = 36;
            string name = "Adam";
            string position = "Manager";
            int tenure = 15;
            

            //String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old. I have been a " + position + " for " + tenure + " years.");

            //String formatting using string indexing
            //Format is {#}
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I have been a {2} for {3} years.", name, age, position, tenure);

            //String interpolation
            //string interpolation begin with $ at the start which allows us to write variable names as {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old. I have been a {position} for {tenure} years"); //must include $ at the beginning to define interpolation

            //Verbatim strings
            //verbatim strings begin with @ at the start and tells the compiler to take the string literally, ignoring any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"ridiculously long text message
            next line with tabs
next line with no tabs,      extra spaces"); //appears exactly as typed, useful for file paths and website addresses

            //String methods, "string" is an object of the System.String class
            //Functions of the "String" class are used to manipulate and to perform various actions on a given string

            //SubString(int32) - is used to get the substring fromm the string, each letter is indexed. example CARS would have C at index 1, A at index 2
            //ToLower() - converts the string to lowercase
            //ToUpper() - converts the string to upper case
            //Trim() - trims all leading and trailing whitespace from the string
            //IndexOf(string) - is used to get the first occurrence of the string or character inside the string
            //IsNullOrWhiteSpace - returns true if the string is null/blank and false if it contains data

            string firstName = "Adam";
            string lastName = "Ockey";
            string fakeName = "Bob";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2)); //ouput "am"
            Console.WriteLine(firstName.ToLower()); //output "adam"
            Console.WriteLine(firstName.ToUpper()); // output "ADAM"
            Console.WriteLine(fullName.Trim()); // output "AdamOckey"
            Console.WriteLine(firstName.IndexOf('a')); //output 2 (0=A 1=d 2=a 3=m)
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); //output "false"

            //String.Format - this method is used to insert object or variable value inside any string
            //with String.Format you can replace the value in a specified format.
            //  String.Format("any string{index}", object) example;
            Console.WriteLine(String.Format("My name is {0}", fakeName));
            Console.Read();

            //**QUIZ**
            string inputName;
            Console.Clear();
            Console.WriteLine("Please enter your name and press enter...");
            inputName = Console.ReadLine();
            Console.WriteLine(inputName.ToUpper()); //converts to upper case and displays (shorthand)
            string inputNameUpperCase = String.Format("Upper case : {0}", inputName.ToUpper()); //converts to upper case (format)
            Console.WriteLine(inputNameUpperCase); //display
            Console.WriteLine(inputName.ToLower()); //converts to lower case and displays (shorthand)
            string inputNameLowerCase = String.Format("Lower case : {0}", inputName.ToLower()); //converts to lower case (format)
            Console.WriteLine(inputNameLowerCase); //display
            Console.WriteLine(inputName.Trim()); //trims string and displays (shorthand)
            string inputNameTrimmed = String.Format("Trimmed value : {0}", inputName.Trim()); //converts to trimmed string (format)
            Console.WriteLine(inputNameTrimmed);//display
            Console.WriteLine(inputName.Substring(0, 5)); //gets substring of string (shorthand)
            string inputNameSubString = String.Format("Substring value : {0}", inputName.Substring(0, 5));
            Console.WriteLine(inputNameSubString);//display
            Console.ReadKey();

            Console.Clear();
            string newInput; //declare string for input
            char searchContext; //declare string for search
            Console.WriteLine("Enter a string here: "); //print prompt to screen
            newInput = Console.ReadLine(); //assign value to input string
            Console.WriteLine("Enter a character to search for: "); //print prompt to screen
            searchContext = Console.ReadLine()[0]; //assign value to search context
            //the [0] after readline tells it to only accept the first character
            Console.WriteLine(newInput.IndexOf(searchContext)); //print result to screen - search context of new input displayed as index position
            Console.ReadKey();


            Console.Clear();
            Console.Write("Enter the search context here: ");
            //read first input string
            string input = Console.ReadLine();
            Console.WriteLine("Enter the character to search for: ");
            //read the characture input to search for
            char searchInput = Console.ReadLine()[0];
            //gets the index of the character from the string
            int searchIndex = input.IndexOf(searchInput);
            //prints the index as a result on the console
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
            Console.ReadKey();
            
            Console.Clear();
            string _firstName; //declare string for first name
            string _lastName; //declare string for last name
            Console.WriteLine("Please enter your first name...");
            _firstName = Console.ReadLine(); //assign value to first name from user input
            Console.WriteLine("Please enter your last name...");
            _lastName = Console.ReadLine(); //assign value to last name from user input
            string _fullName = string.Concat(_firstName, " ", _lastName);
            Console.WriteLine(_fullName);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            string _userID = String.Format("Your login ID is : {0}{1}", _firstName.Substring(0, 1), _lastName);
            Console.WriteLine(_userID);
            Console.ReadKey();




        }
    }
}
