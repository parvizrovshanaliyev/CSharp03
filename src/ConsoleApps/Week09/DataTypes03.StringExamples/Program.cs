namespace DataTypes03.StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Concatenation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
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

            // Example 5: String Comparison
            string str1 = "hello";
            string str2 = "Hello";
            bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Are strings equal (case-insensitive)? {isEqual}");

            // Example 6: String Format
            int productCount = 5;
            string productMessage = String.Format("There are {0} products in stock.", productCount);
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
            string sentence = String.Join(" ", words);
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
        }
    }
}