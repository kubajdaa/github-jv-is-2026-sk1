
/*
 * Proměnná uchovává odpověď uživatele, zda chce program opakovat.
 * Výchozí hodnota "a" zajistí, že se program spustí alespoň jednou.
 */
string again = "a";

/*
 * Hlavní cyklus umožňuje spustit celý program opakovaně,
 * aniž by ho uživatel musel pokaždé znovu spouštět.
 * ToLower() umožňuje přijmout malé i velké písmeno A.
 */
while (again.ToLower() == "a")
{
    // Vymažeme předchozí výpisy, aby další běh programu začínal čistě.
    Console.Clear();

    // Vyžádáme si počáteční hodnotu číselné řady.
    Console.Write("Napiš first: ");

    // Proměnná bude uchovávat počáteční číslo po ověření vstupu.
    int first;

    /*
     * TryParse se pokusí převést vstup na celé číslo.
     * Pokud se převod nepovede, cyklus se opakuje a žádá nový vstup.
     * Program se tak nezastaví chybou při zadání textu místo čísla.
     */
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine(
            "Nezadal jsi celé číslo braindead. Zkus to znovu a lépe: ");
    }

    // Vyžádáme si poslední hodnotu, ke které má řada dojít.
    Console.Write("Napiš final: ");

    // Uchovává horní hranici číselné řady.
    int last;

    /*
     * Stejně jako u first ověřujeme, zda uživatel zadal celé číslo.
     * Bez této kontroly by program mohl pracovat s neplatným vstupem.
     */
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine(
            "Nezadal jsi celé číslo braindead. Zkus to znovu a lépe: ");
    }

    // Vyžádáme si velikost kroku, o který se bude řada posouvat.
    Console.Write("Napiš step: ");

    // Uchovává rozdíl mezi po sobě jdoucími čísly řady.
    int step;

    /*
     * Kontrolujeme dvě podmínky:
     * 1. Vstup musí být platné celé číslo.
     * 2. Krok musí být větší než nula.
     *
     * Nulový nebo záporný krok by neodpovídal pravidlům této verze
     * programu, která podporuje pouze kladný krok.
     */
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.WriteLine(
            "Nezadal jsi platné celé číslo větší než 0. Zkus to znovu a lépe: ");
    }

    /*
     * Cyklus vypisuje číselnou řadu.
     * Proměnná i začíná na first.
     * Podmínka i < last určuje, že se samotná hodnota last nevypíše,
     * pokud na ni cyklus nedojde dříve.
     * Po každém průchodu se i zvýší o hodnotu step.
     */
    for (int i = first; i < last; i += step)
    {
        // Převedeme číslo na text a vypíšeme ho do konzole.
        // Convert.ToString() zde není nezbytné, protože Console.WriteLine
        // umí vypsat celé číslo přímo.
        Console.WriteLine(Convert.ToString(i));
    }

    // Nabídneme uživateli možnost spustit další číselnou řadu.
    Console.Write(
        "Pro opakování programu stiskněte klávesu A následně enterem potvrďte: ");

    /*
     * Načteme odpověď pro podmínku hlavního cyklu.
     * Operátor ?? zajistí, že proměnná dostane prázdný řetězec,
     * pokud Console.ReadLine() vrátí null.
     */
    again = Console.ReadLine() ?? "";
}

/*
 * Pokud uživatel nezadá A, podmínka hlavního cyklu přestane platit
 * a program se ukončí.
 */
