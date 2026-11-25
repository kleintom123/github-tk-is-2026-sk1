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

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(50); 

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Hledání maxima, minimaa a jejich prvních pozic
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0; // pozice prvního maxima
    int posMin = 0; // potice prního minima

    for( int i = 1; i < n; i++) // i můžeme dát rovný s indexem 1 jelikož bychom porovnávali číslo samo se sebou
    {
        // zjisšťujeme zda i-tý prvek není větší než aktuální hodnota maxima
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        // zjisšťujeme zda i-tý prvek není menší než aktuální hodnota minima
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("====================================");


    // Vykreslení přesýpacích hodin
    if (max >= 3)
    {
        // Vnější cyklus řídí vykreslování jednotlivých řádků
        for(int i = 0; i < max; i++)
        {
            int spaces = 0; // proměnná pro počet úvodních mezer v aktuálním řádku
            int stars = 0; // proměnná pro počet hvězdiček v aktuálním řádku

            if(i < max / 2)
            {
                // Horní polovina obrazce
                // počet mezer je přímo úměrný proměnné i 
                spaces = i;
                // Hvězdičky ubývají o dvě na každém řádku
                stars = max - (2 * i);
            }
            else
            {
                // Dolní polovina obrazce
                // TO-DO: samostatně
            }

            // Samostatné vykreslení aktuálního řádku
            // Nejprve vykreslujeme mezery
            for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }

            // Následně vykreslujeme hvězdičky
            for (int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
            
            // Přechod na další řádek, ale až potom co vykreslíme potřebné znaky
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nevykreslí!");
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
