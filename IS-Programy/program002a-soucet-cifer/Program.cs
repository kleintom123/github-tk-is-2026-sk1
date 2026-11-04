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
    Console.WriteLine("*********** Součet cifer ************");
    Console.WriteLine("*************************************");
    Console.WriteLine("********** 2. program yay ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();



    // Načtení první hodnoty
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {number}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    
    // Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 0;    // Neutrální hodnota pro sčítání je 0
    int digit;      // Proměnná pro uložení právě zjištěné číslice   


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klaváseou Enter ");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Chcete program pustit znovu?  ");
    again = Console.ReadLine() ?? "";
}
