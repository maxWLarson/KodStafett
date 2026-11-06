internal class Program
{
    private static void Main(string[] args)
    {
        /*
        fler karaktärstyper 
        val av vapen 
        styrka eller andra egenskaper 
        olika egenskaper beroende på karaktärstyp 
        specialförmågor 
        möjlighet att skapa en ny karaktär 
        en loop på något lämpligt ställe 
        bättre presentation av resultatet
        en helt egen idé

        Färdigt:
        bättre kontroll av felaktiga val
        */

        Console.WriteLine("=== KARAKTÄRSGENERATOR ===");

        Console.Write("Vad heter din karaktär? ");
        string namn = Console.ReadLine();

        Console.WriteLine("Välj karaktärstyp:");
        Console.WriteLine("1. Krigare");
        Console.WriteLine("2. Magiker");
        Console.WriteLine("3. Tjuv");
        
        string karaktärstyp = null;
        int choice;

        while (true)
        {
            Console.Write("Ditt val: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                karaktärstyp = "Krigare";
                break;
            }
            else if (choice == 2)
            {
                karaktärstyp = "Magiker";
                break;
            }
            else if (choice == 3)
            {
                karaktärstyp = "Tjuv";
                break;
            }
            else
            {
                Console.WriteLine("Förlåt, detta är inte ett av valen, snälla kolla igen och skriv in rätt");
            }
        }

        string vapen;
        Console.WriteLine("Vilcket typ av vapen vill du ha:");
        Console.Write("Skriv:");
        vapen = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("=== DIN KARAKTÄR ===");
        Console.WriteLine("Namn: " + namn);
        Console.WriteLine("Typ: " + karaktärstyp);
        Console.WriteLine($"Typ av vapen: {vapen}");
    }
}