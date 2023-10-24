//Onsdag kig på at få den til at skrive hvor mange rækker hver place har været igennem  

public class Bankospil
{
    public static void Main(string[] args)
    {
        // Banko info
        string ID1 = "LukasB";
        string ID2 = "Mikkel";
        string ID3 = "Jonas";
        string ID4 = "Mathias";
        string ID5 = "Bente";
        string ID6 = "Jacob";
        string ID7 = "Bob";
        string ID8 = "Peter";
        string ID9 = "Ole";
        string ID10 = "Margrethe";


        int[,] LukasB = { { 40, 50, 62, 70, 80 }, { 7, 22, 36, 44, 52 }, { 8, 19, 38, 54, 66 } };
        int[,] Mikkel = { { 12, 44, 60, 70, 81 }, { 4, 37, 45, 55, 72 }, { 6, 28, 48, 58, 65 } };
        int[,] Jonas = { { 2, 41, 51, 70, 87 }, { 6, 26, 31, 52, 88 }, { 8, 17, 29, 65, 74 } };
        int[,] Mathias = { { 2, 42, 62, 71, 83 }, { 6, 23, 35, 68, 88 }, { 7, 18, 24, 55, 69 } };
        int[,] Bente = { { 1, 11, 23, 30, 81 }, { 14, 26, 31, 74, 85 }, { 4, 34, 46, 59, 68 } };
        int[,] Jacob = { { 2, 21, 30, 74, 82 }, { 22, 32, 43, 56, 67 }, { 14, 28, 38, 77, 89 } };
        int[,] Bob = { { 6, 10, 24, 32, 40 }, { 7, 35, 41, 56, 73 }, { 29, 39, 48, 68, 89 } };
        int[,] Peter = { { 13, 32, 41, 51, 85 }, { 15, 22, 42, 74, 86 }, { 9, 28, 37, 57, 68 } };
        int[,] Ole = { { 1, 15, 22, 42, 80 }, { 6, 33, 43, 72, 84 }, { 19, 28, 47, 58, 68 } };
        int[,] Margrethe = { { 1, 22, 33, 40, 84 }, { 16, 34, 52, 67, 87 }, { 6, 28, 59, 68, 79 } };


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

        Console.WriteLine($"Plade3: {ID3}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Jonas[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade4: {ID4}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Mathias[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade5: {ID5}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Bente[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade6: {ID6}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Jacob[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade7: {ID7}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Bob[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade8: {ID8}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Peter[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade9: {ID9}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Ole[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Plade10: {ID10}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Margrethe[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Mark numbers as user inputs them
        bool[,] LukasBMarked = new bool[3, 5];
        bool[,] MikkelMarked = new bool[3, 5];
        bool[,] JonasMarked = new bool[3, 5];
        bool[,] MathiasMarked = new bool[3, 5];
        bool[,] BenteMarked = new bool[3, 5];
        bool[,] JacobMarked = new bool[3, 5];
        bool[,] BobMarked = new bool[3, 5];
        bool[,] PeterMarked = new bool[3, 5];
        bool[,] OleMarked = new bool[3, 5];
        bool[,] MargretheMarked = new bool[3, 5];

        // Arrays to track whether each player has achieved banko on each row
        bool[] LukasBRowBanko = new bool[3];
        bool[] MikkelRowBanko = new bool[3];
        bool[] JonasRowBanko = new bool[3];
        bool[] MathiasRowBanko = new bool[3];
        bool[] BenteRowBanko = new bool[3];
        bool[] JacobRowBanko = new bool[3];
        bool[] BobRowBanko = new bool[3];
        bool[] PeterRowBanko = new bool[3];
        bool[] OleRowBanko = new bool[3];
        bool[] MargretheRowBanko = new bool[3];

        while (true)
        {
            Console.WriteLine("Enter a number between 1 and 90: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 90)
            {
                Console.WriteLine("Please enter a number between 1 and 90.");
                continue; // Restart the loop
            }

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
                    if (Jonas[i, j] == number)
                    {
                        JonasMarked[i, j] = true;
                    }
                    if (Mathias[i, j] == number)
                    {
                        MathiasMarked[i, j] = true;
                    }
                    if (Bente[i, j] == number)
                    {
                        BenteMarked[i, j] = true;
                    }
                    if (Bob[i, j] == number)
                    {
                        BobMarked[i, j] = true;
                    }
                    if (Peter[i, j] == number)
                    {
                        PeterMarked[i, j] = true;
                    }
                    if (Ole[i, j] == number)
                    {
                        OleMarked[i, j] = true;
                    }
                    if (Margrethe[i, j] == number)
                    {
                        MargretheMarked[i, j] = true;
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
                if (!JonasRowBanko[i] && CheckBankoRow(JonasMarked, i))
                {
                    Console.WriteLine($"Jonas has banko on row {i + 1}!");
                    JonasRowBanko[i] = true;
                }
                if (!MathiasRowBanko[i] && CheckBankoRow(MathiasMarked, i))
                {
                    Console.WriteLine($"Mathias has banko on row {i + 1}!");
                    MathiasRowBanko[i] = true;
                }
                if (!BenteRowBanko[i] && CheckBankoRow(BenteMarked, i))
                {
                    Console.WriteLine($"Bente has banko on row {i + 1}!");
                    BenteRowBanko[i] = true;
                }
                if (!JacobRowBanko[i] && CheckBankoRow(JacobMarked, i))
                {
                    Console.WriteLine($"Jacob has banko on row {i + 1}!");
                    JacobRowBanko[i] = true;
                }
                if (!BobRowBanko[i] && CheckBankoRow(BobMarked, i))
                {
                    Console.WriteLine($"Bob has banko on row {i + 1}!");
                    BobRowBanko[i] = true;
                }
                if (!PeterRowBanko[i] && CheckBankoRow(PeterMarked, i))
                {
                    Console.WriteLine($"Peter has banko on row {i + 1}!");
                    PeterRowBanko[i] = true;
                }
                if (!OleRowBanko[i] && CheckBankoRow(OleMarked, i))
                {
                    Console.WriteLine($"Ole has banko on row {i + 1}!");
                    OleRowBanko[i] = true;
                }
                if (!MargretheRowBanko[i] && CheckBankoRow(MargretheMarked, i))
                {
                    Console.WriteLine($"Margrethe has banko on row {i + 1}!");
                    MargretheRowBanko[i] = true;
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
