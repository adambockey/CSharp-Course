using System;

namespace Learning_NamingConventions
{
    class Program
    {
        ///<summary>
        ///This is the Main Method - Adam wrote this
        /// </summary>
        //Summary code is used before a method to describe it's purpose, shows up in the tool tip when you hover over the method.
        static void Main(string[] args) //Main Method (Commented to explain method's purpose)
        {
            /* Multi line comments can be added using /* and closing with the reverse
             * allows you to type on multiple lines instead of using multiple // tags.
             */

            int userAge = 15;
            //Defines User age and is named as such, name of variable should reflect data or use.

            Console.WriteLine("Hello World!");
            Console.WriteLine("Variables & Methods should be named according to your organizations internal policies.");
            Console.WriteLine("Methods should be named in a way that describes their function for easy recall");
            Console.WriteLine("Variables should be named according to their data, or where you use them, or what type of data they store.");
            Console.WriteLine("For Example, in this program we have a variable named userAge which stores the users age, which is " + userAge);
            Console.WriteLine("The method in this program is named Main, which is used as it is the main and only method in the program.");
            Console.ReadKey();
            //Example - the WriteLine method writes a line to the Console, it is named to reflect that and is easy to determine it's use.

           /* Avoid abbreviation whenever possible!, example userControl not usrCtrl
            * Do not use actual numbers in Variable names, example threeCars not 3Cars
            * Actual numbers can be used at the *END* of variable names, example threeCars3 or cars3
            * 
            * Namespaces should have each word capitalized, example WhereIKeepMyClasses
            * Classes should have each word capitalized, example WhereIKeepMyMethods
            * Classes should be named using nouns or noun phrases, example Employee, BusinessDate
            * Methods should have each word capitalized, example WhereIDoThings
            * Methods should be named using Verbs or Actions, example GetDate, GetEmployeeInformation
            * Arguments should have camel casing, example thisIsMyArgument
            * Local** Varaibles should have camel casing, example myVariable
            * avoid _ (underscore) in the middle of variables, and _ (underscore) can be used at the beginning of a variable
            * avoid assiging variable names that are the same or similar to existing predefined type names, example String, Bool, Int

            //this is PascalCasing, this is camelCasing
            //avoid using Hungarian notation, example iInterger, strString
        }
    }
}
