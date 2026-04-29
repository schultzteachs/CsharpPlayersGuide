Sieve Test = new Sieve();
Console.WriteLine("Pick a filter:");
Console.WriteLine("Even");
Console.WriteLine("Positive");
Console.WriteLine("Ten");
string response ="";



try
{
    response = Console.ReadLine();
}
catch (FormatException)
{
    Console.WriteLine("Must be a string!");
}

switch (response)
{
    case "Even": Test.NumCheck = Test.IsEven; break;
    case "Positive": Test.NumCheck = Test.IsPositive; break;
    case "Ten": Test.NumCheck = Test.IsDiv10; break;
}

while (true)
{
    try
    {
        Console.WriteLine("Give a number and I will tell if its good or bad:");
        int num = Int32.Parse(Console.ReadLine());
        bool x = Test.NumCheck(num);
        Console.WriteLine($"Number is good:{x}");
    }
    catch (FormatException) { Console.WriteLine("Enter a NUMBER."); }

    

}




Console.ReadKey();




public class Sieve()
{

    public checker NumCheck;


    
    public bool IsEven(int number)
    {
        return (number % 2 == 0);
    }
    public bool IsPositive(int number)
    {
        return (number > 0);
    }
    public bool IsDiv10(int number)
    {
        return (number % 10 == 0);
    }
    public delegate bool checker(int num);
}



/*Gemini-created Solution (for notes):
 * 
 * 
 * // 1. Get the choice FIRST
Console.WriteLine("Pick a filter: Even, Positive, or Ten");
string response = Console.ReadLine();

// 2. Decide the method BEFORE creating the Sieve
checker selectedMethod = response switch
{
    "Even" => IsEven,
    "Positive" => IsPositive,
    "Ten" => IsDiv10,
    _ => IsEven // A default fallback so it never crashes!
};

// 3. Pass the method into the constructor (as the challenge intended)
Sieve mySieve = new Sieve(selectedMethod);

while (true)
{
    try {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is it good? {mySieve.IsGood(num)}");
    }
    catch (FormatException) { Console.WriteLine("Numbers only, please!"); }
}

// Logic Methods (outside the class or inside)
bool IsEven(int n) => n % 2 == 0;
bool IsPositive(int n) => n > 0;
bool IsDiv10(int n) => n % 10 == 0;

// The Class
public class Sieve(checker method) // Primary Constructor!
{
    public bool IsGood(int n) => method(n);
}

public delegate bool checker(int num);
 * 
 * 
 * 
 * 
 * 
 * 




/* NOTES from chapter
Console.WriteLine($"Here is the input: numberthing(10)");

NumDelegate numberthing = AddOne;
numberthing += SubtractOne;
numberthing += Double;

int AddOne(int number) => number + 1;
int SubtractOne(int number) => number - 1;
int Double(int number) => number * 2;


Console.WriteLine($"Here is the output:{numberthing(10)}");

Console.ReadKey();



public delegate int NumDelegate(int num);

*/