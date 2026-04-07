
Console.WriteLine("Give a number:");

while (true)
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int result))
    {
        Console.WriteLine("That is a number!");
        break;
    }
    else if (double.TryParse(s, out double Dresult))
    {
        Console.WriteLine("That is a decimal, try again!");
    }
    else if (bool.TryParse(s, out bool Bresult))
    {
        Console.WriteLine("That is a boolean, try again!");
    }
    else
    {
        Console.WriteLine("That is not a number, try again!");
    }
}