namespace Week10.Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math");

            // Max
            Console.WriteLine(System.Math.Max(2, 4));

            // Min
            Console.WriteLine(System.Math.Min(2, 4));

            // Math.Sqrt(x)     
            Console.WriteLine(System.Math.Sqrt(64));


            // Math.Abs(x)
            Console.WriteLine(System.Math.Abs(-4.7));

            // Math.Round()
            Console.WriteLine(System.Math.Round(-4.7));

            Console.WriteLine(System.Math.Round(-4.2));
        }
    }
}