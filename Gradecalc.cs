using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop
            while (true)
            {
                // user input
                Console.Write("Enter a numerical grade between 0 and 100 (or type 'q' to quit): ");
                string input = Console.ReadLine();

                // quit option
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit  loop option
                }

                
                if (double.TryParse(input, out double grade))
                {
                    // check that the grade is within the acceptable range (0-100)
                    if (grade >= 0 && grade <= 100)
                    {
                        // letter grade  asssignments
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
                        // case  when  insert is not within valid  nmber range
                        Console.WriteLine("Error: Please enter a grade between 0 and 100.\n");
                    }
                }
                else
                {
                    // case  when  insert is not a  valid  nmber
                    Console.WriteLine("Error: Invalid input. Please enter a number or 'q' to quit.\n");
                }
            }

            // Message displayed when the program exits
            Console.WriteLine("Thank you for using the Grade Converter!");
        }
    }
}
