using System;

public class Bankospil
{
    public static void Main(string[] args)
    {
        // Banko info
        string ID1 = "LukasB";
        string ID2 = "Mikkel";
        string ID3 = "";
        string ID4 = "";
        string ID5 = "";

        int[,] LukasB = { { 40, 50, 62, 70, 80 }, { 7, 22, 36, 44, 52 }, { 8, 19, 38, 54, 66 } };
        int[,] Mikkel = { { 12, 44, 60, 70, 81 }, { 4, 37, 45, 55, 72 }, { 6, 28, 48, 58, 65 } };

        // Display info
        Console.WriteLine($"Plade1: {ID1}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(LukasB[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade2: {ID2}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Mikkel[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Mark numbers as user inputs them
        bool[,] LukasBMarked = new bool[3, 5];
        bool[,] MikkelMarked = new bool[3, 5];

        // Arrays to track whether each player has achieved banko on each row
        bool[] LukasBRowBanko = new bool[3];
        bool[] MikkelRowBanko = new bool[3];

        while (true)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Mark the number on the corresponding board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (LukasB[i, j] == number)
                    {
                        LukasBMarked[i, j] = true;
                    }
                    if (Mikkel[i, j] == number)
                    {
                        MikkelMarked[i, j] = true;
                    }
                }
            }

            // Check for banko on each row and update the row banko status
            for (int i = 0; i < 3; i++)
            {
                if (!LukasBRowBanko[i] && CheckBankoRow(LukasBMarked, i))
                {
                    Console.WriteLine($"LukasB has banko on row {i + 1}!");
                    LukasBRowBanko[i] = true;
                }
                if (!MikkelRowBanko[i] && CheckBankoRow(MikkelMarked, i))
                {
                    Console.WriteLine($"Mikkel has banko on row {i + 1}!");
                    MikkelRowBanko[i] = true;
                }
            }
        }
    }

    private static bool CheckBankoRow(bool[,] marked, int row)
    {
        for (int j = 0; j < 5; j++)
        {
            if (!marked[row, j])
            {
                return false;
            }
        }
        return true;
    }
}
