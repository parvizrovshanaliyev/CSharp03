namespace Week10.Homework
{

    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3.1: Value Types
            int age = 25;
            double height = 5.11;
            char grade = 'A';
            bool isStudent = true;

            Console.WriteLine($"Age: {age}, Height: {height}, Grade: {grade}, IsStudent: {isStudent}");

            // Exercise 3.2: Arithmetic Operators
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;

            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}");

            // Exercise 3.2: Assignment Operators
            int initialValue = 5;
            int preIncremented = ++initialValue;
            int postIncremented = initialValue++;

            Console.WriteLine(
                $"Initial value: {initialValue}, Pre-incremented value: {preIncremented}, Post-incremented value: {postIncremented}");

            // Exercise 3.2: Logical Operators
            Console.Write("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            bool withinRange = (userNumber >= 10) && (userNumber <= 20);
            Console.WriteLine($"Is the number within the range of 10 and 20? {withinRange}");

            // Exercise 3.2: Comparison Operators
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            bool stringsEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Are the strings equal? {stringsEqual}");

            // Exercise 3.3: Math Operations
            Console.Write("Enter the first number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            double max = Math.Max(num3, Math.Max(num4, num5));
            Console.WriteLine($"Maximum: {max}");

            Console.Write("Enter the numbers separated by spaces: ");
            string[] numbers = Console.ReadLine().Split(' ');
            double[] doubleNumbers = Array.ConvertAll(numbers, double.Parse);
            double min = doubleNumbers.Min();
            Console.WriteLine($"Minimum: {min}");

            Console.Write("Enter a number: ");
            double num6 = Convert.ToDouble(Console.ReadLine());
            double squareRoot = Math.Sqrt(num6);
            Console.WriteLine($"Square root: {squareRoot}");

            Console.Write("Enter a negative number: ");
            double negativeNumber = Convert.ToDouble(Console.ReadLine());
            double absoluteValue = Math.Abs(negativeNumber);
            Console.WriteLine($"Absolute value: {absoluteValue}");

            Console.Write("Enter a decimal number: ");
            double decimalNumber = Convert.ToDouble(Console.ReadLine());
            long roundedValue = (long)Math.Round(decimalNumber);
            Console.WriteLine($"Rounded value: {roundedValue}");

            // Exercise 3.4: String Operations
            Console.Write("Enter the first string: ");
            string str3 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str4 = Console.ReadLine();

            string concatenatedString = str3 + str4;
            Console.WriteLine($"Concatenated string: {concatenatedString}");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int ageInput = Convert.ToInt32(Console.ReadLine());

            string message = $"Hello, {name}! You are {ageInput} years old.";
            Console.WriteLine(message);

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string upperCase = inputString.ToUpper();
            string lowerCase = inputString.ToLower();
            string substring = inputString.Substring(2, 5);
            int indexOfW = inputString.IndexOf('W');

            Console.WriteLine(
                $"Uppercase: {upperCase}, Lowercase: {lowerCase}, Substring (2, 5): {substring}, Index of 'W': {indexOfW}");
        }
    }
}
