string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.Write("Napiš first: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadal jsi celé číslo braindead. Zkus to znovu a lépe: ");
    }

    Console.Write("Napiš final: ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadal jsi celé číslo braindead. Zkus to znovu a lépe: ");
    }
    Console.Write("Napiš step: ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.WriteLine("Nezadal jsi platné celé číslo větší než 0. Zkus to znovu a lépe: ");
    }

    for (int i = first; i < last; i += step)
    {
        Console.WriteLine(Convert.ToString(i));
    }

    Console.Write("Pro opakování programu stiskněte klávesu A následně enterem potvrďte: ");
    again = Console.ReadLine() ?? "";
}