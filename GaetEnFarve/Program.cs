using System;

class Program
{
    static void Main()
    {
        // 1) Farver (muligheder)
        string color1 = "rød";
        string color2 = "blå";
        string color3 = "grøn";
        string color4 = "gul";
        string color5 = "lilla";

        // 2) Random vælger et tilfældigt tal
        Random random = new Random();
        int chosenColorNumber = random.Next(1, 6); // 1..5 (6 er ikke med)

        // 3) Vi finder farven ud fra tallet (switch)
        string chosenColor = "";

        switch (chosenColorNumber)
        {
            case 1:
                chosenColor = color1;
                break;
            case 2:
                chosenColor = color2;
                break;
            case 3:
                chosenColor = color3;
                break;
            case 4:
                chosenColor = color4;
                break;
            case 5:
                chosenColor = color5;
                break;
            default:
                chosenColor = color1; // “sikkerhedsnet”
                break;
        }

        // 4) Spil-indstillinger
        int maxAttempts = 3;
        bool guessedCorrectly = false;

        Console.WriteLine("Velkommen til 'Gæt en Farve'!");
        Console.WriteLine("Jeg har valgt en farve. Kan du gætte, hvilken farve det er?");
        Console.WriteLine($"Du har {maxAttempts} forsøg.");

        // 5) For-loop: giver spilleren 3 forsøg
        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write($"Forsøg {attempt}: Indtast dit gæt: ");
            string userGuess = Console.ReadLine().ToLower();

            // 6) If: tjekker om gættet er rigtigt
            if (userGuess == chosenColor)
            {
                guessedCorrectly = true;
                Console.WriteLine($"Tillykke! Du gættede rigtigt! Farven var {chosenColor}.");
                break; // stop loopet, fordi spillet er vundet
            }
            else
            {
                Console.WriteLine("Forkert gæt. Prøv igen.");
            }
        }

        // 7) Efter loopet: hvis man ikke gættede rigtigt
        if (!guessedCorrectly)
        {
            Console.WriteLine($"Du har brugt alle dine forsøg. Den rigtige farve var {chosenColor}. Bedre held næste gang!");
        }
    }
}
