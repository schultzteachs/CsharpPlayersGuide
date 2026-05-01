Exception GAMEOVER = new Exception("Game Over");

//ask for name
Console.WriteLine("What is your name? Press enter when done.");
string? PlayerName = Console.ReadLine();

if ((string.IsNullOrWhiteSpace(PlayerName)))
{
    PlayerName = "playerAnon";
}

int PlayerScore = 0;
//check for file with same name

if (File.Exists($"{PlayerName}.txt")){
    string previous = File.ReadAllText($"{PlayerName}.txt");
    Console.WriteLine($"Last time you scored: {previous}");
}
else
{
    File.WriteAllText($"{PlayerName}.txt", PlayerScore.ToString());
}
//if no file, make a new one

Console.WriteLine("Ready to play? Hit as many keys as you can! Press enter when done.");
bool GameOn = true;

try
{
    while (GameOn)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        Console.WriteLine(key.Key);
        if (key.Key == ConsoleKey.Enter)
        {
            throw GAMEOVER;
        }
        PlayerScore++;
        Console.WriteLine($"Current score: {PlayerScore}");
        
    }
}
catch (Exception)
{
    GameOn = false;
    Console.WriteLine($"Good job, {PlayerName}! Your score is:{PlayerScore}");
}
File.WriteAllText($"{PlayerName}.txt", PlayerScore.ToString());


/*When the file starts, ask for a name
 * player starts with score of 0
 * add one point for every key press
 * display score after each key press
 * When player hits enter, end game
 * Console.ReadKey().Key == ConsoleKey.Enter
 * Save score to a text file. No name files should be *. Game should be able to load score based on name.
 * 
 * 
 * 
 */
