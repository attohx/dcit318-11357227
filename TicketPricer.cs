using System;
using System.Globalization;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the culture to Ghana to correctly format currency
            CultureInfo ghanaCulture = new CultureInfo("en-GH");

            // Define ticket pricesin decimal
            const decimal standardPrice = 10.00m;
            const decimal discountedPrice = 7.00m;

            // Define age limits for discounts
            const int childAgeLimit = 12;
            const int seniorAgeLimit = 65;

            // Loop to allow more than 1 calculation
            while (true)
            {
                // ask the user for their age
                Console.Write("Enter your age (or type 'q' to quit): ");
                string input = Console.ReadLine();

                // ask if the user wants to quit
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop
                }

                // Try to parse the input string into an integer.
                if (int.TryParse(input, out int age))
                {
                    // Validate that the age is a non-negative number
                    if (age >= 0)
                    {
                        decimal ticketPrice;

                        // Check if the age qualifies for a discount
                        if (age <= childAgeLimit || age >= seniorAgeLimit)
                        {
                            ticketPrice = discountedPrice;
                        }
                        else
                        {
                            ticketPrice = standardPrice;
                        }
                        
                        // Display the result in ghana crrency
                        Console.WriteLine($"Your ticket price is: {ticketPrice.ToString("C", ghanaCulture)}\n");
                    }
                    else
                    {
                        // cases where the age is negative
                        Console.WriteLine("Error: Please enter a valid, non-negative age.\n");
                    }
                }
                else
                {
                    // cases where the input is not a valid number
                    Console.WriteLine("Error: Invalid input. Please enter a number or 'q' to quit.\n");
                }
            }

            // Message displayed when the program closes
            Console.WriteLine("Thank you for using the Ticket Price Calculator!");
        }
    }
}
