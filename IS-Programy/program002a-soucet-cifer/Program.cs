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
    Console.WriteLine("******** Součet a součin cifer ******");
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
    int product = 1;  // Neutrální hodnota pro součin je 1
    int digit;      // Proměnná pro uložení právě zjištěné číslice


    // ošetření záporných čísel (znaménko nemá vliv na číslice)
    if(number < 0){
        number = -number;
    }

    // Zvláštní případ pro nulu
    if(number == 0)
    {
        sum = 0;
        product = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava)");

        // Matematický rozklad čísla pomocí cyklu
        // Využíváme operaci modulo - určení zbytku po celočíselném dělení
        while(number > 0)
        {
            digit = number % 10; // Modulo 10 - získáme poslední číslici
            sum = sum + digit; // Přičtení číslice k celkovému součtu
            product = product * digit; // Násobení číslic

            Console.WriteLine($"Získaná číslice: {digit}");

            number = number / 10; // Celočíselné dělení 10 odtraní poslední číslici
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum}.");
    Console.WriteLine($"Součin číslic čísla {numberBackup} je {product}.");
    Console.WriteLine("================================================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klaváseou Enter ");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Chcete program pustit znovu?  ");
    again = Console.ReadLine() ?? "";

}
