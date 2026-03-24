Console.WriteLine("Guess a number");

int testNum = Int32.Parse(Console.ReadLine());

Console.Clear();

int Guesses = 0;

int GuessNum = -1;

while (testNum != GuessNum)
{
    Console.WriteLine("Guess the original number...");
    GuessNum = Int32.Parse(Console.ReadLine());
    if (GuessNum < testNum)
    {
        Console.WriteLine("Too low");
    }
    if (GuessNum > testNum)
    {
        Console.WriteLine("Too high");
    }
    if (GuessNum == testNum)
    {
        Console.WriteLine("That's the number");
        break;
    }
}