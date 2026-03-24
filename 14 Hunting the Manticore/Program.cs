int ManticoreHealth = 10;
int CityHealth = 15;
int RoundNum = 1;
int CannonDamage = 1;


Console.WriteLine("Player One: Choose the Manticore's distance from the city (0 to 100)");
int Distance = Int32.Parse(Console.ReadLine());
Console.Clear();

while ((ManticoreHealth >= 0) || (CityHealth >= 0))
{
    Console.WriteLine($"-----------------------------------------------------");
    Console.WriteLine($"Round: {RoundNum}");
    Console.WriteLine($"City Health: {CityHealth}");
    Console.WriteLine($"Manticore Health: {ManticoreHealth}");
    Console.WriteLine($"-----------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Cannons are LOADED"); //make this red!
    Console.ForegroundColor = ConsoleColor.White; //change it back
    CannonDamage = CannonCalc(RoundNum, CannonDamage);

    Console.WriteLine($"The cannon will do {CannonDamage} points of damage this round!");
    Console.WriteLine($"Player Two: Protect the City! How far is the Manticore?");
    int Shot = Int32.Parse(Console.ReadLine());

    if (Shot == Distance)
    {
        //change the color for hit
        Console.WriteLine($"Hit!!! Manticore takes {CannonDamage}");
        ManticoreHealth = ManticoreHealth - CannonDamage;
    }
    else if (Shot >= Distance)
    {
        Console.WriteLine($"MISS!!! The round was OVERSHOT");
    }
    else if (Shot <= Distance)
    {
        Console.WriteLine($"MISS!!! The round was SHORT");
    }
    else
    {
        Console.WriteLine("BUG:Something went wrong!");
    }
    RoundNum = RoundNum + 1;
    CityHealth = CityHealth - 1;
    Console.WriteLine($"Manticore showers bombs on the city. City health is now {CityHealth}");


    if (ManticoreHealth <= 0)
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Game Over!");
        Console.WriteLine("The Manticore was DESTROYED");
        Console.WriteLine("The city is saved!!! <3");
        break;
    }
    if (CityHealth <= 0)
    {
        Console.WriteLine("----------------------------------------------");  
        Console.WriteLine("Game Over!");
        Console.WriteLine("The City was DESTROYED");
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine("EVIL REIGNS >;)");
        break;
    }
}




//if round number is multiple of both 3 and 5, cannon damage is 10
//if round number is multiple of 3 OR 5, cannon damage is 3
static int CannonCalc(int RoundNum, int CannonDamage)
{
    if ((RoundNum % 5 == 0) && (RoundNum % 3 == 0))
    {
        CannonDamage = 10;
    }
    else if ((RoundNum % 5 == 0) || (RoundNum % 3 == 0))
    {
        CannonDamage = 3;
    }
    else
    {
        CannonDamage = 1;
    }

    return CannonDamage;
}