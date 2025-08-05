using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop to allow multiple triangle identifications
            while (true)
            {
                Console.WriteLine("Enter the lengths of the three sides of a triangle.");
                Console.WriteLine("Type 'q' at any prompt to quit.\n");

                // Get and validate the three side lengths from the user
                double side1 = GetSide("Enter the length of side 1: ");
                if (double.IsNaN(side1)) break; // Exit if user quit

                double side2 = GetSide("Enter the length of side 2: ");
                if (double.IsNaN(side2)) break; // Exit if user quit

                double side3 = GetSide("Enter the length of side 3: ");
                if (double.IsNaN(side3)) break; // Exit if user quit

                // Validate if the given sides can form a triangle using the Triangle Inequality Theorem
                // The sum of the lengths of any two sides of a triangle must be greater than the length of the third side.
                if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
                {
                    string triangleType;

                    // Determine the type of the triangle
                    if (side1 == side2 && side2 == side3)
                    {
                        triangleType = "Equilateral"; // All three sides are equal
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        triangleType = "Isosceles"; // Exactly two sides are equal
                    }
                    else
                    {
                        triangleType = "Scalene"; // No sides are equal
                    }

                    Console.WriteLine($"\nThe triangle is: {triangleType}\n");
                }
                else
                {
                    // If the sides do not form a valid triangle
                    Console.WriteLine("\nError: The entered side lengths do not form a valid triangle.\n");
                }
            }
             // Message displayed when the program exits
            Console.WriteLine("Thank you for using the Triangle Type Identifier!");
        }

        // function to get and validate user input for a side length
        static double GetSide(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // Check if the user wants to quit
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    return double.NaN; // NaN as a signal to quit
                }

                // Try to parse the input and ensure it's a positive number
                if (double.TryParse(input, out double side) && side > 0)
                {
                    return side; // Return the valid side length
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Error: Please enter a valid, positive number.");
                }
            }
        }
    }
}
