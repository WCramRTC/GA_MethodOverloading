namespace GA_MethodOverloading
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            EmployeeDatabase database = new EmployeeDatabase();

            // Math operations
            int sum1 = math.Add(10, 5);
            Console.WriteLine($"Sum1: {sum1}");

            double difference = math.Subtract(7.5, 3.2);
            Console.WriteLine($"Difference: {difference}");

            double product = math.Multiply(4.0, 2.5, 3.0);
            Console.WriteLine($"Product: {product}");

            try
            {
                double result = math.Divide(8.0, 2.0);
                Console.WriteLine($"Division Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Employee database
            database.AddEmployee("John Doe");
            database.AddEmployee("Jane Smith", 30);
            database.AddEmployee("Robert Johnson", 25, "HR");
        } // main

    } // class

} // namespace
