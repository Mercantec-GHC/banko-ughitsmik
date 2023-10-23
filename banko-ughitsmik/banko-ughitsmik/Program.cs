public class Bankospil
{
    public static void Main(string[] args)
    {
        //Banko info
        string ID1 = "LukasB";
        string ID2 = "Mikkel";
        string ID3 = "";
        string ID4 = "";
        string ID5 = "";

        int[,] LukasB = { { 40, 50, 62, 70, 80 }, { 7, 22, 36, 44, 52 }, { 8, 19, 38, 54, 66 } };
        int[,] Mikkel = { { 12, 44, 60, 70, 81 }, { 4, 37, 45, 55, 72 }, { 6, 28, 48, 58, 65 } };

        //Display info
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
    }
}