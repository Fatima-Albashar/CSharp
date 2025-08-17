using System;

namespace MathOperationApp
{
    // This is a class that will contain our method
    class MathProcessor
    {
        // This void method takes two integers as parameters
        // It performs a math operation on the first integer (e.g., multiplies it by 2)
        // Then it prints the second integer to the screen
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2 (example math operation)
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of the operation on the first number: " + result);

            // Display the second number to the screen
            Console.WriteLine("Second number: " + secondNumber);
        }
    }

    class Program
    {
        // The Main method is the entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathProcessor class so we can use its methods
            MathProcessor processor = new MathProcessor();

            // Call the method using positional arguments
            // This will pass 5 as the first number and 10 as the second number
            processor.ProcessNumbers(5, 10);

            // Call the method using named parameters for clarity
            processor.ProcessNumbers(firstNumber: 7, secondNumber: 3);

            // Pause the console to view output before it closes
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
