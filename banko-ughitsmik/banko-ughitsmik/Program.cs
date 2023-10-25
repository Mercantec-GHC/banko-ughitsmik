public class bankoGame
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

        string ID11 = "Ella";
        string ID12 = "Freja";
        string ID13 = "William";
        string ID14 = "Karl";
        string ID15 = "Frida";
        string ID16 = "Luna";
        string ID17 = "Emil";
        string ID18 = "Oscar";
        string ID19 = "Ida";
        string ID20 = "Oliver";

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

        int[,] Ella = { { 14, 21, 33, 40, 81 }, { 8, 16, 46, 56, 63 }, { 9, 18, 39, 58, 77 } };
        int[,] Freja = { { 4, 23, 34, 41, 52 }, { 5, 12, 36, 55, 74 }, { 38, 48, 58, 66, 89 } };
        int[,] William = { { 13, 33, 40, 72, 82 }, { 2, 18, 35, 53, 83 }, { 5, 29, 66, 79, 89 } };
        int[,] Karl = { { 11, 31, 46, 54, 82 }, { 5, 47, 55, 63, 84 }, { 8, 29, 48, 77, 89 } };
        int[,] Frida = { { 11, 46, 51, 63, 84 }, { 6, 24, 47, 55, 67 }, { 16, 28, 35, 69, 76 } };
        int[,] Luna = { { 2, 23, 54, 64, 71 }, { 5, 18, 41, 56, 67 }, { 9, 39, 59, 69, 90 } };
        int[,] Emil = { { 1, 34, 42, 65, 80 }, { 15, 26, 54, 66, 81 }, { 9, 17, 45, 68, 75 } };
        int[,] Oscar = { { 2, 10, 40, 50, 84 }, { 3, 13, 24, 65, 85 }, { 5, 39, 47, 77, 90 } };
        int[,] Ida = { { 23, 30, 45, 51, 71 }, { 5, 13, 35, 46, 74 }, { 7, 38, 68, 77, 90 } };
        int[,] Oliver = { { 15, 50, 63, 73, 80 }, { 8, 25, 32, 47, 65 }, { 36, 49, 54, 77, 84 } };


        // Display info
        Console.WriteLine($"Card 1: {ID1}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(LukasB[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 2: {ID2}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Mikkel[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 3: {ID3}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Jonas[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 4: {ID4}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Mathias[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 5: {ID5}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Bente[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 6: {ID6}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Jacob[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 7: {ID7}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Bob[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 8: {ID8}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Peter[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 9: {ID9}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Ole[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 10: {ID10}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Margrethe[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 11: {ID11}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Ella[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 12: {ID12}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Freja[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 13: {ID13}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(William[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 14: {ID14}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Karl[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 15: {ID15}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Frida[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 16: {ID16}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Luna[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 17: {ID17}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Emil[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 18: {ID18}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Oscar[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 19: {ID19}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Ida[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Card 20: {ID20}");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(Oliver[i, j] + " ");
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

        bool[,] EllaMarked = new bool[3, 5];
        bool[,] FrejaMarked = new bool[3, 5];
        bool[,] WilliamMarked = new bool[3, 5];
        bool[,] KarlMarked = new bool[3, 5];
        bool[,] FridaMarked = new bool[3, 5];
        bool[,] LunaMarked = new bool[3, 5];
        bool[,] EmilMarked = new bool[3, 5];
        bool[,] OscarMarked = new bool[3, 5];
        bool[,] IdaMarked = new bool[3, 5];
        bool[,] OliverMarked = new bool[3, 5];

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

        bool[] EllaRowBanko = new bool[3];
        bool[] FrejaRowBanko = new bool[3];
        bool[] WilliamRowBanko = new bool[3];
        bool[] KarlRowBanko = new bool[3];
        bool[] FridaRowBanko = new bool[3];
        bool[] LunaRowBanko = new bool[3];
        bool[] EmilRowBanko = new bool[3];
        bool[] OscarRowBanko = new bool[3];
        bool[] IdaRowBanko = new bool[3];
        bool[] OliverRowBanko = new bool[3];

        // Variables to track whether each player has achieved a full card
        bool LukasBFullCard = false;
        bool MikkelFullCard = false;
        bool JonasFullCard = false;
        bool MathiasFullCard = false;
        bool BenteFullCard = false;
        bool JacobFullCard = false;
        bool BobFullCard = false;
        bool PeterFullCard = false;
        bool OleFullCard = false;
        bool MargretheFullCard = false;

        bool EllaFullCard = false;
        bool FrejaFullCard = false;
        bool WilliamFullCard = false;
        bool KarlFullCard = false;
        bool FridaFullCard = false;
        bool LunaFullCard = false;
        bool EmilFullCard = false;
        bool OscarFullCard = false;
        bool IdaFullCard = false;
        bool OliverFullCard = false;

        while (true)
        {
            Console.WriteLine("Enter a number between 1 and 90: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 90)
            {
                Console.WriteLine("Number not valid. Please enter a number between 1 and 90.");
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
                    if (Ella[i, j] == number)
                    {
                        EllaMarked[i, j] = true;
                    }
                    if (Freja[i, j] == number)
                    {
                        FrejaMarked[i, j] = true;
                    }
                    if (William[i, j] == number)
                    {
                        WilliamMarked[i, j] = true;
                    }
                    if (Karl[i, j] == number)
                    {
                        KarlMarked[i, j] = true;
                    }
                    if (Frida[i, j] == number)
                    {
                        FridaMarked[i, j] = true;
                    }
                    if (Luna[i, j] == number)
                    {
                        LunaMarked[i, j] = true;
                    }
                    if (Emil[i, j] == number)
                    {
                        EmilMarked[i, j] = true;
                    }
                    if (Oscar[i, j] == number)
                    {
                        OscarMarked[i, j] = true;
                    }
                    if (Ida[i, j] == number)
                    {
                        IdaMarked[i, j] = true;
                    }
                    if (Oliver[i, j] == number)
                    {
                        OliverMarked[i, j] = true;
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
                if (!EllaRowBanko[i] && CheckBankoRow(EllaMarked, i))
                {
                    Console.WriteLine($"Ella has banko on row {i + 1}!");
                    EllaRowBanko[i] = true;
                }
                if (!FrejaRowBanko[i] && CheckBankoRow(FrejaMarked, i))
                {
                    Console.WriteLine($"Freja has banko on row {i + 1}!");
                    FrejaRowBanko[i] = true;
                }
                if (!WilliamRowBanko[i] && CheckBankoRow(WilliamMarked, i))
                {
                    Console.WriteLine($"William has banko on row {i + 1}!");
                    WilliamRowBanko[i] = true;
                }
                if (!KarlRowBanko[i] && CheckBankoRow(KarlMarked, i))
                {
                    Console.WriteLine($"Karl has banko on row {i + 1}!");
                    KarlRowBanko[i] = true;
                }
                if (!FridaRowBanko[i] && CheckBankoRow(FridaMarked, i))
                {
                    Console.WriteLine($"Frida has banko on row {i + 1}!");
                    FridaRowBanko[i] = true;
                }
                if (!LunaRowBanko[i] && CheckBankoRow(LunaMarked, i))
                {
                    Console.WriteLine($"Luna has banko on row {i + 1}!");
                    LunaRowBanko[i] = true;
                }
                if (!EmilRowBanko[i] && CheckBankoRow(EmilMarked, i))
                {
                    Console.WriteLine($"Emil has banko on row {i + 1}!");
                    EmilRowBanko[i] = true;
                }
                if (!OscarRowBanko[i] && CheckBankoRow(OscarMarked, i))
                {
                    Console.WriteLine($"Oscar has banko on row {i + 1}!");
                    OscarRowBanko[i] = true;
                }
                if (!IdaRowBanko[i] && CheckBankoRow(IdaMarked, i))
                {
                    Console.WriteLine($"Ida has banko on row {i + 1}!");
                    IdaRowBanko[i] = true;
                }
                if (!OliverRowBanko[i] && CheckBankoRow(OliverMarked, i))
                {
                    Console.WriteLine($"Oliver has banko on row {i + 1}!");
                    OliverRowBanko[i] = true;
                }
            }

            // Check if players achieved a full card
            if (!LukasBFullCard && CheckFullCard(LukasBMarked))
            {
                Console.WriteLine("LukasB has achieved BANKO a full card!");
                LukasBFullCard = true;
            }

            if (!MikkelFullCard && CheckFullCard(MikkelMarked))
            {
                Console.WriteLine("Mikkel has achieved BANKO on a full card!");
                MikkelFullCard = true;
            }
            if (!JonasFullCard && CheckFullCard(JonasMarked))
            {
                Console.WriteLine("Jonas has achieved BANKO on a full card!");
                JonasFullCard = true;
            }

            if (!MathiasFullCard && CheckFullCard(MathiasMarked))
            {
                Console.WriteLine("Mathias has achieved BANKO on a full card!");
                MathiasFullCard = true;
            }
            if (!BenteFullCard && CheckFullCard(BenteMarked))
            {
                Console.WriteLine("Bente has achieved BANKO on a full card!");
                BenteFullCard = true;
            }

            if (!JacobFullCard && CheckFullCard(JacobMarked))
            {
                Console.WriteLine("Jacob has achieved BANKO on a full card!");
                JacobFullCard = true;
            }
            if (!BobFullCard && CheckFullCard(BobMarked))
            {
                Console.WriteLine("Bob has achieved BANKO on a full card!");
                BobFullCard = true;
            }

            if (!PeterFullCard && CheckFullCard(PeterMarked))
            {
                Console.WriteLine("Peter has achieved BANKO on a full card!");
                PeterFullCard = true;
            }
            if (!OleFullCard && CheckFullCard(OleMarked))
            {
                Console.WriteLine("Ole has achieved BANKO on a full card!");
                OleFullCard = true;
            }

            if (!MargretheFullCard && CheckFullCard(MargretheMarked))
            {
                Console.WriteLine("Margrethe has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!EllaFullCard && CheckFullCard(EllaMarked))
            {
                Console.WriteLine("Ella has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!FrejaFullCard && CheckFullCard(FrejaMarked))
            {
                Console.WriteLine("Freja has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!WilliamFullCard && CheckFullCard(WilliamMarked))
            {
                Console.WriteLine("William has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!KarlFullCard && CheckFullCard(KarlMarked))
            {
                Console.WriteLine("Karl has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!FridaFullCard && CheckFullCard(FridaMarked))
            {
                Console.WriteLine("Frida has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!LunaFullCard && CheckFullCard(LunaMarked))
            {
                Console.WriteLine("Luna has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!EmilFullCard && CheckFullCard(EmilMarked))
            {
                Console.WriteLine("Emil has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!OscarFullCard && CheckFullCard(OscarMarked))
            {
                Console.WriteLine("Oscar has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!IdaFullCard && CheckFullCard(IdaMarked))
            {
                Console.WriteLine("Ida has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            if (!OliverFullCard && CheckFullCard(OliverMarked))
            {
                Console.WriteLine("Oliver has achieved BANKO on a full card!");
                MargretheFullCard = true;
            }

            // Check if all players have achieved a full card, you can break out of the loop
            if (LukasBFullCard && MikkelFullCard && JonasFullCard && MathiasFullCard && BenteFullCard && JacobFullCard && BobFullCard && PeterFullCard && OleFullCard && MargretheFullCard && EllaFullCard && FrejaFullCard && WilliamFullCard && KarlFullCard && FridaFullCard && LunaFullCard && EmilFullCard && OscarFullCard && IdaFullCard && OliverFullCard)
            {
                Console.WriteLine("All players have achieved banko on a full card. The game is over.");
                break;
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

    private static bool CheckFullCard(bool[,] marked)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (!marked[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
