using System;

class Program
{
    static void Main()
    {
        // Display welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight
        Console.Write("Please enter the package weight: ");
        string weightInput = Console.ReadLine(); // Read user input
        float packageWeight = float.Parse(weightInput); // Convert input to float

        // Check if the package weight exceeds the limit
        if (packageWeight > 50)
        {
            // Display error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt the user to enter the package width
        Console.Write("Please enter the package width: ");
        string widthInput = Console.ReadLine(); // Read user input
        float packageWidth = float.Parse(widthInput); // Convert input to float

        // Prompt the user to enter the package height
        Console.Write("Please enter the package height: ");
        string heightInput = Console.ReadLine(); // Read user input
        float packageHeight = float.Parse(heightInput); // Convert input to float

        // Prompt the user to enter the package length
        Console.Write("Please enter the package length: ");
        string lengthInput = Console.ReadLine(); // Read user input
        float packageLength = float.Parse(lengthInput); // Convert input to float

        // Calculate the total dimensions by adding width, height, and length
        float dimensionTotal = packageWidth + packageHeight + packageLength;

        // Check if the total dimensions exceed the allowed limit
        if (dimensionTotal > 50)
        {
            // Display error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the quote using the formula:
        // (width * height * length) * weight / 100
        float quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

        // Display the shipping quote formatted to two decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

        // Display a thank you message
        Console.WriteLine("Thank you!");
    }
}
