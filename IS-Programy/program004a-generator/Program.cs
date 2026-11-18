string again = "a";

while (again.ToLower() == "a")
{
    
    
        Console.Clear();
    

    Random generator = new Random();
    int sudy = 0;
    int lichy = 0;
    int kladny = 0;
    int zaporny = 0;

    Console.WriteLine("Napis horni mez");
    int max;
    string? input;
    while (true)
    {
        input = Console.ReadLine();
        if (input == null) return;
        if (int.TryParse(input, out max) && max > int.MinValue) break;
        Console.WriteLine("Zadej celé číslo větší než " + int.MinValue + ": ");
    }

    Console.WriteLine("Napis spodni mez");
    int min;
    while (true)
    {
        input = Console.ReadLine();
        if (input == null) return;
        if (int.TryParse(input, out min) && min < max) break;
        Console.WriteLine("Zadej celé číslo menší než horní mez: ");
    }

    Console.WriteLine("Napis kolik jich chces vygenerovat");
    int count;
    while (true)
    {
        input = Console.ReadLine();
        if (input == null) return;
        if (int.TryParse(input, out count) && count > 0) break;
        Console.WriteLine("Zadej celé číslo větší než 0: ");
    }

    for(int i = 0; i < count; i++)
    {
        int rndNum = generator.Next(min,max);
        Console.WriteLine(rndNum);
        if(rndNum%2==0){sudy++;}else{lichy++;}
        if(rndNum>0){kladny++;}else {zaporny++;}
    }

    Console.WriteLine("Počet sudých čísel: "+ sudy);
    Console.WriteLine("Počet lichých čísel: "+ lichy);
    Console.WriteLine("Počet kladných čísel: "+ kladny);
    Console.WriteLine("Počet záporných čísel: "+ zaporny);

    Console.Write("Pro opakování programu stiskněte klávesu A následně enterem potvrďte: ");
    again = Console.ReadLine() ?? "";
}
