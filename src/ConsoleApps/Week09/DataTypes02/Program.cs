namespace DataTypes02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integral Types -> default 0
            int myInt = 42;
            long myLong = 1234567890123456789L;
            short myShort = 32000;
            byte myByte = 255;

            // Floating-Point Types
            float myFloat = 3.14f;
            double myDouble = 3.14159;

            // Decimal Type
            decimal myDecimal = 123.456m;

            // Boolean Type -> default false
            bool isTrue = true;

            // Character Type
            char myChar = 'A';

            // String Type --> Reference Type  default value -> null
            string myString = "Hello, world!";

            string myString2;

            // Object Type
            object myObject = 42;

            // Nullable Types
            int? nullableInt = null;

            // Print examples
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"bool: {isTrue}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"string: {myString}");
            Console.WriteLine($"object: {myObject}");
            Console.WriteLine($"nullableInt: {nullableInt}");


            // Type casting examples
            // Implicit casting
            int intValue = myShort; // Implicit casting from short to int
            double doubleValue = myFloat; // Implicit casting from float to double

            Console.WriteLine($"Implicit casting: int value: {intValue}, double value: {doubleValue}");

            // Explicit casting
            int explicitIntValue = (int)myLong; // Explicit casting from long to int
            byte explicitByteValue = (byte)myInt; // Explicit casting from int to byte

            Console.WriteLine($"Explicit casting: int value: {explicitIntValue}, byte value: {explicitByteValue}");


            // Explicit type casting methods
            int intValue2 = 42;
            double doubleValue2 = 3.14;
            bool boolValue = true;

            // Convert.ToInt32() method
            int convertedInt = Convert.ToInt32(doubleValue2);
            Console.WriteLine($"Converted double to int using Convert.ToInt32(): {convertedInt}");

            // Convert.ToDouble() method
            double convertedDouble = Convert.ToDouble(intValue2);
            Console.WriteLine($"Converted int to double using Convert.ToDouble(): {convertedDouble}");

            // Convert.ToBoolean() method
            bool convertedBool = Convert.ToBoolean(intValue2);
            Console.WriteLine($"Converted int to bool using Convert.ToBoolean(): {convertedBool}");

            // Convert.ToString() method
            string convertedString = Convert.ToString(boolValue);
            Console.WriteLine($"Converted bool to string using Convert.ToString(): {convertedString}");

            // Character Type
            char myChar2 = 'A'; // Char literals are enclosed in single quotes

            // Boolean Type
            bool isTrue2 = true; // Boolean literals are either true or false

            // Special conventions for char and bool
            // Char can be implicitly converted to int, representing its Unicode value
            int charUnicode = myChar2;
            Console.WriteLine($"Unicode value of char 'A': {charUnicode}");

            // Bool can be implicitly converted to string
            string boolToString = isTrue2.ToString();
            Console.WriteLine($"Bool converted to string: {boolToString}");

            // Bool can be implicitly converted to int, where true is 1 and false is 0
            int boolToInt = isTrue2 ? 1 : 0;
            Console.WriteLine($"Bool converted to int: {boolToInt}");
            

            // Keep the console window open
            Console.ReadLine();
        }
    }
}