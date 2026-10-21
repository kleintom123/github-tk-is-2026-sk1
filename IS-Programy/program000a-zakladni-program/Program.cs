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
    Console.WriteLine("************ Název programu *************");
    Console.WriteLine("*************************************");
    Console.WriteLine("********* # program yay *********");
    Console.WriteLine("*************************************");



    // Načtení první hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Načtení druhé hodnoty
    Console.Write("Zadejte další číslo (celé číslo): ");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo znovu: ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {aaa}; Další číslo: {bbb}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klaváseou Enter ");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Chcete program pustit znovu?  ");
    again = Console.ReadLine() ?? "";
}
