namespace Week10.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Operators");

            /*
             *
             * Arithmetic Operators
               Arithmetic operators are used to perform common mathematical operations:
               
               Operator	Name	Description	Example	Try it
               +	Addition	Adds together two values	x + y	
               -	Subtraction	Subtracts one value from another	x - y	
               *	Multiplication	Multiplies two values	x * y	
               /	Division	Divides one value by another	x / y	
               %	Modulus	Returns the division remainder	x % y	
               ++	Increment	Increases the value of a variable by 1	x++	
               --	Decrement	Decreases the value of a variable by 1	x--
             */


            // Modulus
            int x = 5;
            int y = 2;

            int result = x % y;

            Console.WriteLine(result);


            int userInput = Console.Read();

            int divider = 2;

            bool result1 = (userInput % divider) == 0; // (userInput % divider) ->  4 % 2 --> 0 == 0 --> true or false

            if (result1 == true) // result = true 
            {
                Console.WriteLine("Not Single digit.");
            }
            else // result = false
            {
                Console.WriteLine("It is a single digit");
            }

            if ((userInput % divider) == 0) // result = true 
            {
                Console.WriteLine("Not Single digit.");
            }
            else // result = false
            {
                Console.WriteLine("It is a single digit");
            }

            // Ternary operator ->   ? :
            string message = (userInput % divider) == 0
                ? "Not Single digit."
                : "It is a single digit";

            Console.WriteLine(message);

            int userInput1 = Console.Read();

            if (userInput1 == (int)Months.January)
            {
                Console.WriteLine(Months.January);
            }
            else if (userInput1 == (int)Months.February)
            {
                Console.WriteLine(Months.February);
            }
            else
            {
                Console.WriteLine("not valid");
            }

            // ++	Increment	Increases the value of a variable by 1	x++	

            int z1, z2, sum;

            z1 = 5;
            z2 = 6;

            sum = z1 + z2;
            Console.WriteLine(sum);

            sum += 2;
            //sum = sum + 2;
            Console.WriteLine(sum);

            sum++;
            Console.WriteLine(sum);

            ++sum;
            Console.WriteLine(sum);


            /*
         *
         * Assignment Operators
           Assignment operators are used to assign values to variables:
           
           Operator	Example	Same As
           =	x = 5	x = 5	
           +=	x += 3	x = x + 3	
           -=	x -= 3	x = x - 3	
           *=	x *= 3	x = x * 3	
           /=	x /= 3	x = x / 3	
           %=	x %= 3	x = x % 3	
         */

            // Assignment Operators
            int a, b;

            a = 10;
            b = 5;

            a += b; // Equivalent to: a = a + b;
            Console.WriteLine(a);

            a -= 3; // Equivalent to: a = a - 3;
            Console.WriteLine(a);

            a *= 2; // Equivalent to: a = a * 2;
            Console.WriteLine(a);

            a /= 4; // Equivalent to: a = a / 4;
            Console.WriteLine(a);

            a %= 3; // Equivalent to: a = a % 3;
            Console.WriteLine(a);

            /*
         *
         * Comparison Operators
           Comparison operators are used to compare two values:
           
           Operator	Name	Description	Example
           ==	Equal to	Returns true if both values are equal	x == y	
           !=	Not equal to	Returns true if the values are not equal	x != y	
           >	Greater than	Returns true if the left operand is greater than the right operand	x > y	
           <	Less than	Returns true if the left operand is less than the right operand	x < y	
           >=	Greater than or equal to	Returns true if the left operand is greater than or equal to the right operand	x >= y	
           <=	Less than or equal to	Returns true if the left operand is less than or equal to the right operand	x <= y	
         */

            // Comparison Operators
            bool result3;
            string message3;

            // Equal to (==)
            result3 = 4 % 2 == 0; // Modulus
            message3 = result3 == true ? "not Single" : "Single";
            Console.WriteLine(message3);

            // Not equal to (!=)
            bool result2;
            string message2;

            result2 = 4 % 2 != 0; // Modulus
            message2 = result2 == true ? "not Single" : "Single";
            Console.WriteLine(message2);


            /*
             *
             * Logical Operators
               Logical operators are used to combine conditional statements:

               Operator	Name	Description	Example
               && 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
               || 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
               !	Logical not	Reverse the result, returns false if the result is true	!(x < 5 && x < 10)
             */

            // Logical Operators
            int x5 = 5, y6 = 10;

            bool condition1 = x5 < 5 && y6 < 10; // Logical AND
            bool condition2 = x5 < 5 || y6 < 10; // Logical OR
            bool condition3 = !(x5 < 5 && y6 < 10); // Logical NOT

            Console.WriteLine(condition1);
            Console.WriteLine(condition2);
            Console.WriteLine(condition3);


            /*
             *
             * Ternary Operator
               The ternary operator is a concise way to express conditional statements.
               Syntax: condition ? expression1 : expression2
               If condition is true, expression1 is evaluated; otherwise, expression2 is evaluated.
             */

            int userInput2 = 6;
            string resultMessage = (userInput2 % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(resultMessage); // Output: Even
        }
    }

    public enum Months
    {
        January = 1,
        February = 2,
    }
}