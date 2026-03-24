string? name = Console.ReadLine();

Console.WriteLine($"This is returned: {name}");

Console.WriteLine("Who is the chud? ");


string chud = Console.ReadLine()!;

Console.WriteLine(Rodrigo.SayTheThing(chud));
class Rodrigo
{
    public string Name = "Rodrigo";

    public static string SayTheThing(string chud)
    {
        return "You're not the guy. You " + chud ?? "YOU CANT COOK YOU CHUD WOULDNT FEED TO DOG";
    }
}



