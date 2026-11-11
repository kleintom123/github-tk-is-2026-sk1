string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    //Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("******* Vykreslování obrazců ********");
    Console.WriteLine("*************************************");
    Console.WriteLine("********** 3. program yay ***********");
    Console.WriteLine("*************************************");



    // Bezpečné načtení šířky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte číslo znovu: ");
    }

    // Bezpečné načtení výšky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte číslo znovu: ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
    Console.WriteLine("================================================");
    Console.WriteLine();

    // Jádro algoritmu: Vnořený cyklus pro 2D rastr
    // Vnější cyklus počítá řádky (shora dolů)
    for(int i = 1; i <= height; i++)
    {
        //Vnitřní cyklus sází sloupce v aktuálním řádku (zleva doprava)
        for(int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
        }

        // Konec řádku -> přesun kurzoru na nový řádek
        Console.WriteLine();
    }
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klaváseou Enter ");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Chcete program pustit znovu?  ");
    again = Console.ReadLine() ?? "";
}
