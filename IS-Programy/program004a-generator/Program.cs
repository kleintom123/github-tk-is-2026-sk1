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
    Console.WriteLine("********* Generátor čísel ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** 4. program yay **********");
    Console.WriteLine("*************************************");



    // Počet generovaných čísel (větší než nula)
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno než dolní mez: ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo menší než dolní mez. Zadejte horní mez znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=======================================================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("=======================================================");
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem

    // Deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];
    int positiveNumbs = 0;
    int negativeNumbs = 0;
    int zeros = 0;
    int even = 0;
    int odd = 0;

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(50); 

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");
        
        /*if(myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] == 0)
           zeros++;  
        */

        // efektivnější předchozí
        if(myRandNumbs[i] < 0)
            negativeNumbs++;
        else if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else
            zeros++;
        

        //počítání sudých nebo lichých čísel
        if(myRandNumbs[i] % 2 == 0 )
            even++;
        else
            odd++;  
                
            
    }

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Počet kladných čísel: {positiveNumbs}");
    Console.WriteLine($"Počet záporných čísel: {negativeNumbs}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine("====================================");

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Počet sudých čísel: {even}");
    Console.WriteLine($"Počet záporných čísel: {odd}");
    Console.WriteLine("====================================");



    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klaváseou Enter ");
    Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Chcete program pustit znovu?  ");
    again = Console.ReadLine() ?? "";
}
