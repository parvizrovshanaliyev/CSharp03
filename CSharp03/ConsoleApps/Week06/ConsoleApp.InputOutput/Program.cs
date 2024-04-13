namespace ConsoleApp.InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // print the sum of two numbers
            int number1 = 5;
            int number2 = 10;

            Console.WriteLine(number1 + number2);


            int sum = number1 + number2; // 15

            Console.WriteLine("print the sum of two numbers :" + sum);
            Console.WriteLine("print the sum of two numbers :" + number1 + "+" + number2 + "=" + sum);

            string text = "print the sum of two numbers : 5 + 10=15";
            string text1 = "print the sum of two numbers :" + "5";
            string text2 = "print the sum of two numbers :5";
            string text3 = "print the sum of two numbers :5" + "+";
            string text4 = "print the sum of two numbers :5 +";
            string text5 = "print the sum of two numbers :5 +" + number2; // 5 + 10

            Console.WriteLine(text5);


            Console.WriteLine("Salam");

            string name = "Saida";

            Console.WriteLine(name);
            Console.WriteLine("name:" + name);


            string surname = "Suleymanli";

            Console.WriteLine(surname);
            Console.WriteLine("surname :" + surname);


            string fullname = "Saida Suleymanli";

            Console.WriteLine(fullname);
            Console.WriteLine("fullname :" + fullname);


            string fullname1 = name + " " + surname;

            Console.WriteLine("fullname1 :" + fullname1);
        }
    }
}