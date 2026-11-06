internal class Program
{
    private static void Main(string[] args)
    {
        /*kostnad för inträde
         * fickpengar klar
         * fråga efter användarens budget
         * tala om ifall utflykten håller budgeten
         * rabatt för stora grupper
         * olika priser beroende på användarens val
         * kontroll av felaktig inmatning
         * möjlighet att göra en ny beräkning
         * en loop på något lämpligt ställe
         * en helt egen idé3*/
        Random random = new Random();

        Console.WriteLine("=== UTFLYKTSKALKYLATOR ===");

        Console.Write("Hur många personer ska följa med? ");
        int antal = Convert.ToInt32(Console.ReadLine());
        int[] pocketmoney = new int[antal];
        for (int i = 0; i < pocketmoney.Length; i++)
        {
            pocketmoney[i] = random.Next(0, 999);
        }

        Console.Write("Vad kostar resan per person? ");
        int resa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vad kostar maten per person? ");
        int mat = Convert.ToInt32(Console.ReadLine());

        // Räknar ut kostnaden för en person.
        int kostnadPerPerson = resa + mat;

        // Räknar ut kostnaden för hela gruppen.
        int totalKostnad = kostnadPerPerson * antal;

        Console.WriteLine();
        Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr");
        Console.WriteLine("Total kostnad: " + totalKostnad + " kr");
        for (int i = 0; i < pocketmoney.Length; i++)
        {
            Console.WriteLine($"Person har {pocketmoney[i]} kr.");
        }
    }
}