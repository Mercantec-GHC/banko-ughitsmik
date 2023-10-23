using System;

namespace Banko
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a 3 by 9 array to store the numbers
            int[,] numbers = new int[3, 9];

            // Prompt the user to enter the numbers
            Console.WriteLine("Enter 27 numbers, one per line:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Display the numbers in an array
            Console.WriteLine("[");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(numbers[i, j]);
                    if (j < 8)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
                if (i < 2)
                {
                    Console.WriteLine(",");
                }
            }
            Console.WriteLine("]");
        }
    }
}