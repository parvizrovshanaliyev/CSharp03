namespace DataTypesTypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type casting
             */

            /*
             * implicit casting - auto
             */

            //int myInt2 = Int32.MaxValue;

            //double myDouble2 = myInt;


            // Declaring and initializing 
            // implicitly typed variables
            var a = 50;
            var b = "Welcome! Geeks";
            var c = 340.67d;
            var d = false;

            int num1 = 5;
            var num2 = 6;

            // Display the type of the variables
            Console.WriteLine("Type of 'a' is : {0} ", a.GetType());

            Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            Console.WriteLine("Type of 'd' is : {0} ", d.GetType());


            /*
             * explicit casting - manual - lost
             */

            //int myInt2 = (int)myDouble;


            // Type Conversion Methods

            // using Convert
            int myInt = 10; // "10"
            double myDouble = 5.25; //  to int -> 5 
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // using Parse
            string m = "100";

            // converting string to int type
            int n = int.Parse(m);
            Console.WriteLine("Original string value: " + m);
            Console.WriteLine("Converted int value: " + n);

            string text = "Admin";

            bool validValue = int.TryParse(text, out num1);

            Console.WriteLine(validValue);

                /*
                 * data types
                 *
                 * Value Types -> Stack
                 *  -- Integral numeric types
                 *  -- Floating-point numeric types
                 *  -- bool that represents a Boolean value
                 *  -- char that represents a Unicode UTF-16 character - to int
                 *
                 *     Value Types
                   
                   In C#, all the "things" declared with the following list of type
                   declarations are Value types (because they are from System.ValueType):
                   
                   bool
                   byte
                   char
                   decimal
                   double
                   enum
                   float
                   int
                   long
                   sbyte
                   short
                   struct
                   uint
                   ulong
                   ushort
    
                 * Reference Types -> Heap
                 * Reference Types
                   
                   All the "things" declared with the types in this list are Reference types (and inherit from System.Object... except, of course, for object which is the System.Object object):
                   
                   class
                   interface
                   delegate
                   object
                   string
                 *
                 */

            string myText = "Hello world"; // char = array // immutable
            myText = myText + " add";

            myText += " add 2";

            var january = Months.January;

            Console.WriteLine(january);

            int y = 10;

            int x = y; // 10
            int discount = y + 18; // 28

            y = 20;

            Console.WriteLine($"y : {y}");

            Console.WriteLine("x : " + x);





            Console.ReadLine();

        }
    }

    public enum DocumentTypes
    {
        Local = 5,
        Remote
    }

    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
}