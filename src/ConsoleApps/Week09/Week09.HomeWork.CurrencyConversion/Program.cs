namespace Week09.HomeWork.CurrencyConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Code Exercise: Currency Conversion
               
               **Objective:**
               Write a C# program that converts an amount in one currency to another currency using both implicit and explicit type casting.
               
               **Scenario:**
               You are developing a financial application that needs to convert currency amounts from one currency to another for international transactions.
               The currency exchange rates are provided as `double` values.
               
               **Instructions:**
               1. Declare a variable `amountInUSD` of type `double` and initialize it with an amount in US dollars.
               2. Declare another variable `exchangeRate` of type `double` and initialize it with the exchange rate from US dollars to another currency (e.g., Euro).
               3. Declare a variable `amountInEuro` of type `double`.
               4. Perform an implicit type cast from `double` (US dollars) to `int` (Euro) and store the result in `amountInEuro`.
               5. Print a message indicating the original amount in US dollars and the converted amount in Euro, using the implicit type cast.
               6. Repeat the process, but this time perform an explicit type cast and print the results.
               7. Ensure that the program handles fractional amounts accurately.
            
             */

            // Declare and initialize variables
            double amountInUSD = 100.50;
            double exchangeRate = 0.88; // Example exchange rate from USD to Euro
            double amountInEuro;

            // Implicit type cast
            amountInEuro = amountInUSD * exchangeRate;
            int implicitAmountInEuro = (int)amountInEuro; // Explicitly cast to int

            // Print results for implicit type cast
            Console.WriteLine("Original amount in US dollars: $" + amountInUSD);
            Console.WriteLine("Implicitly converted amount in Euro: €" + implicitAmountInEuro);

            // Explicit type cast
            amountInEuro = amountInUSD * exchangeRate;
            int explicitAmountInEuro = (int)Math.Round(amountInEuro, 2); // Explicitly cast to int with rounding

            // Print results for explicit type cast
            Console.WriteLine("\nOriginal amount in US dollars: $" + amountInUSD);
            Console.WriteLine("Explicitly converted amount in Euro: €" + explicitAmountInEuro);
        }
    }
}