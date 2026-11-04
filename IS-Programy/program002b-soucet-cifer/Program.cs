string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    //Hlavička programu
    Console.WriteLine("**********************************************");
    Console.WriteLine("**** Součet cifer a součin (nematematicky) ***");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** 2. program yay *****************");
    Console.WriteLine("**********************************************");
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

    // Příprava pomocných proměnných
    int numberBackup = number;
    int sum = 0; // Neutrální hodnota pro sčítání
    int product = 1; // Neutrální hodnota pro násobení
    int digit;
    
    // Převedení čísla na string
    string numberString = number.ToString();

    Console.WriteLine();
    Console.WriteLine("Průběh rozkladu čísla na číslice pomocí stringu");

    // Procházení jednotlivých znaků stringu
    int i = 0;
    while (i < numberString.Length)
    {
        // Přeskočení znaménka mínus
        if(numberString[i] != '-')
        {
            // Převod znaku na celé číslo
            digit = int.Parse(numberString[i].ToString());

            // Výpočet součtu cifer
            sum = sum + digit;

            // Výpočet součinu cifer
            product = product * digit;

            Console.WriteLine($"Získaná číslice: {digit}");
        }

        // Posun na další znak stringu
        i++;
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
