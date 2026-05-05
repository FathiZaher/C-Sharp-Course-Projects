using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the opening welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Requirement: Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End program if weight is too high
                return;
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Requirement: If the sum of dimensions is greater than 50, display error and end
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculation Logic:
            // 1. Multiply dimensions (Volume)
            // 2. Multiply by weight
            // 3. Divide by 100
            float quote = ((height * width * length) * weight) / 100;

            // Display the final quote formatted as a currency amount ($0.00)
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
            
            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
