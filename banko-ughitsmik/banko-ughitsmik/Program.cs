using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create the lists of numbers
        var LukasB1 = new List<int[]>()
        {
            new int[] { 2, 15, 30, 60, 72 },
            new int[] { 4, 18, 24, 56, 84 },
            new int[] { 5, 38, 48, 68, 87 },
        };

        var Mikkel1 = new List<int[]>()
        {
            new int[] { 12, 44, 60, 70, 81 },
            new int[] { 4, 37, 45, 55, 72 },
            new int[] { 6, 28, 48, 58, 65 },
        };

        // Keep track of which numbers have been checked
        var checkedNumbers = new HashSet<int>();

        // Keep inputting numbers until the user enters "exit"
        bool keepGoing = true;
        while (keepGoing)
        {
            // Get the user input
            Console.WriteLine("Enter a number to check or \"exit\" to quit: ");
            string userInput = Console.ReadLine();

            // Check if the user wants to quit
            if (userInput.ToLower() == "exit")
            {
                keepGoing = false;
                break;
            }

            // Check the user input against the lists of numbers
            bool foundInLukasB1 = false;
            bool foundInMikkel1 = false;

            foreach (int[] row in LukasB1)
            {
                if (row.Contains(int.Parse(userInput)))
                {
                    foundInLukasB1 = true;
                    break;
                }
            }

            foreach (int[] row in Mikkel1)
            {
                if (row.Contains(int.Parse(userInput)))
                {
                    foundInMikkel1 = true;
                    break;
                }
            }

            // Add the checked number to the set of checked numbers
            checkedNumbers.Add(int.Parse(userInput));

            // Display the results
            if (foundInLukasB1 && foundInMikkel1)
            {
                Console.WriteLine("The number {0} is found in both LukasB1 and Mikkel1.", userInput);
            }
            else if (foundInLukasB1)
            {
                Console.WriteLine("The number {0} is found in LukasB1.", userInput);
            }
            else if (foundInMikkel1)
            {
                Console.WriteLine("The number {0} is found in Mikkel1.", userInput);
            }
            else
            {
                Console.WriteLine("The number {0} is not found in either LukasB1 or Mikkel1.", userInput);
            }

            // Announce when every number in the new List<int[]> has been checked
            if (checkedNumbers.Count == LukasB1.Count + Mikkel1.Count)
            {
                Console.WriteLine("All numbers in both LukasB1 and Mikkel1 have been checked.");
            }
        }
    }
}