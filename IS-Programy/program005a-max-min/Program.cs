using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

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
    Console.WriteLine("**********");
    int[]numbers = new int[count];
    for(int i = 0; i < count; i++)
    {
        numbers[i] = generator.Next(min,max);
        Console.WriteLine(numbers[i]);
        if(numbers[i]%2==0){sudy++;}else{lichy++;}
        if(numbers[i]>0){kladny++;}else {zaporny++;}
    }
int maximum = int.MinValue;
int poziceMaxima = 0;
int minimum = int.MaxValue;
int poziceMinima = 0;
    for(int i =0; i < count; i++)
    {
        if(numbers[i]>maximum)
        {
            maximum=numbers[i];
            poziceMaxima=i;
        }
        if(numbers[i]<minimum)
        {
            minimum=numbers[i];
            poziceMinima=i;
        }

        
    }

/*Console.WriteLine("Počet sudých čísel: "+ sudy);
    Console.WriteLine("Počet lichých čísel: "+ lichy);
    Console.WriteLine("Počet kladných čísel: "+ kladny);
    Console.WriteLine("Počet záporných čísel: "+ zaporny);
*/
    Console.WriteLine("**********");
    Console.WriteLine("Maximum: "+maximum);
    Console.WriteLine("Pozice maxima: "+poziceMaxima);
    Console.WriteLine("**********");
    Console.WriteLine("Minimum: "+minimum);
    Console.WriteLine("Pozice minima: "+poziceMinima);
    int index = maximum;
    

string text = "";
    for (int i=index; i>= 1;i-=2)
    {
        for(int x = 0;x<(maximum-i)/2;x++){text+=" ";}
        for(int j=0; j < i; j++)
        {
            
           text+="*";
                
            
        }
        Console.WriteLine(text+" ");
        text="";
    }
    int index1 = 0;
    if(maximum%2==0){index1=2;}else{index1=1;}
    for (int i=index1; i<=index;i+=2)
    {
        for(int x = 0;x<(maximum-i)/2;x++){text+=" ";}
        for(int j=0; j < i; j++)
        {
           text+="*";
                
            
        }
        Console.WriteLine(text+" ");
        text="";
    }
    Console.Write("Pro opakování programu stiskněte klávesu A následně enterem potvrďte: ");
    again = Console.ReadLine() ?? "";
}
