namespace Week08.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ### Code Exercise: Temperature Conversion

            //            **Objective:**
            //                Write a C# program that converts temperature from Fahrenheit to Celsius using both implicit and explicit type casting.

            //            **Scenario:**
            //                You are developing a weather monitoring application that needs to convert temperature readings from Fahrenheit to Celsius for analysis.The temperature readings are received as `double` values in Fahrenheit.

            //            * *Instructions:**
            //                1.Declare a variable `fahrenheitTemp` of type `double` and initialize it with a temperature value in Fahrenheit.
            //            2.Declare another variable `celsiusTemp` of type `double`.
            //            3.Perform an implicit type cast from `double` (Fahrenheit) to `int` (Celsius) and store the result in `celsiusTemp`.
            //            4. Print a message indicating the original temperature in Fahrenheit and the converted temperature in Celsius, using the implicit type cast.
            //            5. Repeat the process, but this time perform an explicit type cast and print the results.
            //            6. Ensure that the program handles fractional temperatures accurately.

            //            **Example Output:**
            //                ```
            //            Original temperature in Fahrenheit: 98.6°F
            //                Implicitly converted temperature in Celsius: 37°C

            //            Original temperature in Fahrenheit: 75.5°F
            //                Explicitly converted temperature in Celsius: 24°C
            //                ```

            //            **Your Task:**
            //                Write a C# program that fulfills the above requirements. You can use the console
            //                application template in Visual Studio or any C# compiler of your choice.



            // Step 1: Declare and initialize fahrenheitTemp
            double fahrenheitTemp = 98.6;

            // Step 2: Declare celsiusTemp
            double celsiusTemp;

            // Step 3: Implicit type cast and store result in celsiusTemp -> (98.6-32) * 5/9 -> (66.6) * 5 / 9 -> 333 /9 -> 37
            celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;

            // Step 4: Print results for implicit type cast
            Console.WriteLine($"Original temperature in Fahrenheit: {fahrenheitTemp}°F");
            Console.WriteLine($"Implicitly converted temperature in Celsius: {celsiusTemp}°C");
            Console.WriteLine();

            // Step 5: Explicit type cast and store result in celsiusTemp
            celsiusTemp = (int)((fahrenheitTemp - 32) * 5 / 9);

            // Step 6: Print results for explicit type cast
            Console.WriteLine($"Original temperature in Fahrenheit: {fahrenheitTemp}°F");
            Console.WriteLine($"Explicitly converted temperature in Celsius: {celsiusTemp}°C");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}