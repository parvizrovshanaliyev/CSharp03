namespace ConsoleApp.InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output "Hello, World!" to the console
            Console.WriteLine("Hello, World!");

            // Define two integer variables and initialize them
            int number1 = 5;
            int number2 = 10;

            // Output the sum of the two numbers
            Console.WriteLine(number1 + number2);

            // Calculate the sum of the two numbers and store it in a variable
            int sum = number1 + number2; // sum = 15

            // Output the sum using different formatting techniques
            Console.WriteLine("print the sum of two numbers: " + sum);
            Console.WriteLine("print the sum of two numbers: " + number1 + "+" + number2 + "=" + sum);

            // Define strings representing various text combinations
            string text = "print the sum of two numbers: 5 + 10 = 15";
            string text1 = "print the sum of two numbers: " + "5";
            string text2 = "print the sum of two numbers: 5";
            string text3 = "print the sum of two numbers: 5" + "+";
            string text4 = "print the sum of two numbers: 5 +";
            string text5 = "print the sum of two numbers: 5 +" + number2; // text5 = "print the sum of two numbers: 5 + 10"

            // Output the concatenated strings
            Console.WriteLine(text5);

            // Output "Salam" to the console
            Console.WriteLine("Salam");

            // Define and output a string variable representing a name
            string name = "Saida";
            Console.WriteLine(name);
            Console.WriteLine("name: " + name);

            // Define and output a string variable representing a surname
            string surname = "Suleymanli";
            Console.WriteLine(surname);
            Console.WriteLine("surname: " + surname);

            // Define and output a string variable representing a full name
            string fullname = "Saida Suleymanli";
            Console.WriteLine(fullname);
            Console.WriteLine("fullname: " + fullname);

            // Concatenate the name and surname variables and output the result
            string fullname1 = name + " " + surname;
            Console.WriteLine("fullname1: " + fullname1);

            // Prompt the user to enter two numbers
            Console.Write("Enter number1: ");
            string number1Str = Console.ReadLine();
            Console.Write("Enter number2: ");
            string number2Str = Console.ReadLine();

            // Output the entered numbers
            Console.WriteLine("number1: " + number1Str);
            Console.WriteLine("number2: " + number2Str);

            // Convert the entered strings to integers, calculate the sum, and output it
            int sum1 = Convert.ToInt32(number1Str) + Convert.ToInt32(number2Str);
            Console.WriteLine("sum: " + sum1);
        }
    }
}
