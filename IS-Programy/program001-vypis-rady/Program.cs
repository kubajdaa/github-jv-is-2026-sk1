string again = "a";

while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("Napiš first");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Napiš final");
    int last = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Napiš step");
    int step = Convert.ToInt32(Console.ReadLine());

    for(int i=first; i<last; i += step)
    {
        Console.WriteLine(Convert.ToString(i));
    }
Console.WriteLine("Pro opakování programu stiskněte klávesu a a následně enterem");
again = Console.ReadLine() ?? "";
}


