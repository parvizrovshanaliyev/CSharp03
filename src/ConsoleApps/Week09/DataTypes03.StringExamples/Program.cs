namespace DataTypes03.StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Type --> Reference Type  default value -> null

            // Example 1: Concatenation
            string firstName = "Jonh";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(firstName + " " + lastName); // new expression
            Console.WriteLine($"Full Name: {fullName}"); 

            // Example 2: String Interpolation
            int age = 30;
            string message = $"Hello, my name is {fullName} and I am {age} years old.";
            Console.WriteLine(message);

            // Example 3: String Length
            int length = fullName.Length;
            Console.WriteLine($"Length of full name: {length}");

            // Example 4: Substring
            string greeting = "Hello, world!";
            string substring = greeting.Substring(7); // Starts from index 7
            Console.WriteLine($"Substring: {substring}");


            substring = substring.Substring(0, 2); // starts from 0 take 2


            // Example 5: String Comparison
            string str1 = "nokia";  // user input 
            string str2 = "Nokia"; // database

            bool isEqual1 = str1 == str2; // false
            bool isEqual2 = str1.Equals(str2); // false
            bool isEqual3 = str2.Equals(str1, StringComparison.OrdinalIgnoreCase); // true

            Console.WriteLine($"Are strings equal ? {isEqual1}");
            Console.WriteLine($"Are strings equal ? {isEqual2}");
            Console.WriteLine($"Are strings equal (case-insensitive)? {isEqual3}");

            // Example 6: String Format
            int productCount = 5;
            string productMessage = String.Format("There are {0} products in stock.{1}", productCount, isEqual1);
            Console.WriteLine(productMessage);

            // Example 7: String Split
            string fruits = "apple,banana,orange";

            string[] fruitArray = fruits.Split(',');

            Console.WriteLine("Fruits:");

            foreach (string fruit in fruitArray)
            {
                Console.WriteLine(fruit);
            }

            // Example 8: String Join
            string[] words = { "Hello", "world", "!" };
            string sentence = String.Join(",", words);
            Console.WriteLine($"Sentence: {sentence}");

            // Example 9: String Contains
            string email = "example@example.com";
            bool containsAtSymbol = email.Contains("@");
            Console.WriteLine($"Email contains '@' symbol? {containsAtSymbol}");

            // Example 10: String IndexOf
            string sentence2 = "The quick brown fox jumps over the lazy dog.";
            int indexOfFox = sentence2.IndexOf("fox");
            Console.WriteLine($"Index of 'fox': {indexOfFox}");

            // Keep the console window open
            Console.ReadLine();



            int x1 = 5;
            int x2 = x1;
            x1 = 6;

            Console.WriteLine(x2);

            string test1 = "Hello ";
            string test2 = test1;

            test1 = "World";

            Console.WriteLine(test2);
        }
    }
}