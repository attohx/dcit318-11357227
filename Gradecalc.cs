using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop indefinitely to allow multiple grade conversions
            while (true)
            {
                // Prompt the user for input
                Console.Write("Enter a numerical grade between 0 and 100 (or type 'q' to quit): ");
                string input = Console.ReadLine();

                // Check if the user wants to quit
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop
                }

                // Try to parse the input string into a double.
                // 'out double grade' declares the 'grade' variable and assigns the parsed value to it if successful.
                if (double.TryParse(input, out double grade))
                {
                    // Validate that the grade is within the acceptable range (0-100)
                    if (grade >= 0 && grade <= 100)
                    {
                        // Determine the letter grade using if-else if statements
                        string letterGrade;
                        if (grade >= 90)
                        {
                            letterGrade = "A";
                        }
                        else if (grade >= 80)
                        {
                            letterGrade = "B";
                        }
                        else if (grade >= 70)
                        {
                            letterGrade = "C";
                        }
                        else if (grade >= 60)
                        {
                            letterGrade = "D";
                        }
                        else
                        {
                            letterGrade = "F";
                        }
                        // Display the result
                        Console.WriteLine($"The letter grade for {grade} is: {letterGrade}\n");
                    }
                    else
                    {
                        // Handle cases where the number is outside the 0-100 range
                        Console.WriteLine("Error: Please enter a grade between 0 and 100.\n");
                    }
                }
                else
                {
                    // Handle cases where the input is not a valid number
                    Console.WriteLine("Error: Invalid input. Please enter a number or 'q' to quit.\n");
                }
            }

            // Message displayed when the program exits
            Console.WriteLine("Thank you for using the Grade Converter!");
        }
    }
}
