
Random _random = new Random();

int RollDie(int sides = 6) => _random.Next(sides) + 1;

Console.WriteLine("Choose a number of sides for the die...");
int Num = int.Parse(Console.ReadLine());

RollDie(Num);