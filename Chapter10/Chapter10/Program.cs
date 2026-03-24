using System.Diagnostics;

Console.WriteLine("How many minutes late were you?");
int answer = Int32.Parse(Console.ReadLine());


static string TardyMachine(int MinutesLate) => MinutesLate switch
{
    < 0 => "You're in class.",
    >= 1 and < 5 => "You're Tardy",
    >= 5 => "You're AWOL",
    _ => "Give a number"

};

// Usage
Console.WriteLine(TardyMachine(answer));
