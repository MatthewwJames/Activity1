using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Check if calc.txt exists and read the values 
        Console.Write("Enter the first value: ");
        // If calc.txt exists, read the values from it
        string input1 = Console.ReadLine();
        Console.Write("Enter the second value: ");
        string input2 = Console.ReadLine();
        // If the user enters a value, it will be used; otherwise, the program will prompt for input
        if (double.TryParse(input1, out double value1) && double.TryParse(input2, out double value2))
        {
            // Perform the multiplication
            double result = value1 * value2;
            // Display the result
            Console.WriteLine($"The result of multiplying {value1} and {value2} is {result}");

            // Store the values in calc.txt
            File.WriteAllText("calc.txt", $"{value1},{value2}");
            // Notify the user that the values have been saved
            Console.WriteLine("Values have been saved to calc.txt");
        }
        // If the input is invalid, notify the user
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }
}