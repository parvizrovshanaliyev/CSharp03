using System;

namespace DataTypesTypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type Casting
             * 
             * Type casting refers to the conversion of one data type to another. 
             * In C#, type casting can be done implicitly or explicitly.
             */

            /*
             * Implicit Casting - Automatically done by the compiler
             * 
             * Implicit casting occurs when the destination data type can hold all possible values of the source data type.
             */

            // Implicitly typed variables
            var a = 50;
            var b = "Welcome! Geeks";
            var c = 340.67d;
            var d = false;

            // Display the type of the variables
            Console.WriteLine("Type of 'a' is: {0}", a.GetType());
            Console.WriteLine("Type of 'b' is: {0}", b.GetType());
            Console.WriteLine("Type of 'c' is: {0}", c.GetType());
            Console.WriteLine("Type of 'd' is: {0}", d.GetType());

            // Explicitly defined variables
            int num1 = 5;
            var num2 = 6;

            /*
             * Explicit Casting - Manually specified by the programmer
             * 
             * Explicit casting is done when there is a need to convert a larger data type to a smaller one, or when precision might be lost.
             */

            // Type Conversion Methods

            // Using Convert class
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            // Convert data types
            Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string

            // Using Parse method
            string m = "100";
            int n = int.Parse(m); // Convert string to int
            Console.WriteLine("Original string value: " + m);
            Console.WriteLine("Converted int value: " + n);

            // Using TryParse method to handle conversion errors without exceptions
            string text = "Admin";
            bool validValue = int.TryParse(text, out num1);
            Console.WriteLine(validValue);

            /*
             * Data Types
             * 
             * In C#, data types specify the type of data that a variable can store. 
             * C# supports two main categories of data types: Value Types and Reference Types.
             */

            // Value Types -> Stored on Stack
            int y = 10;
            int x = y; // x = 10
            int discount = y + 18; // discount = 28
            y = 20;

            // Output variables
            Console.WriteLine($"y: {y}");
            Console.WriteLine("x: " + x);

            /*
             * Enums
             * 
             * Enums allow us to define a set of named integral constants that represent numeric values.
             */

            var january = Months.January;
            Console.WriteLine(january);

            /*
             * Strings and Operations
             * 
             * Strings are immutable in C#, meaning their values cannot be changed once they are created.
             */

            string myText = "Hello world"; // Strings are immutable
            myText = myText + " add"; // Concatenation
            myText += " add 2"; // Compound concatenation

            /*
             * Constants and Read-only Variables
             * 
             * Constants have fixed values that cannot be changed after initialization, while read-only variables can be initialized once and cannot be changed thereafter.
             */

            const double pi = 3.14; // Constant
            // pi = 3.14159; // Error: Cannot modify a constant value

           

            Console.ReadLine();
        }
    }

    // Define custom enum types
    public enum DocumentTypes
    {
        Local = 5,
        Remote
    }

    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
