//copy seive program from chapter 36 to use lambda expressions instead of named methods for the three filters


Sieve Test = new Sieve();
Console.WriteLine("Pick a filter:");
Console.WriteLine("Even");
Console.WriteLine("Positive");
Console.WriteLine("Ten");
string response = "";



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
    case "Even": Test.NumCheck = x => x % 2 == 0; break;
    case "Positive": Test.NumCheck = x =>  x > 0; ; break;
    case "Ten": Test.NumCheck = x =>  x % 10 == 0; break;
    default: Test.NumCheck(0); break;
}

while (true)
{
    Console.WriteLine("Give a number and I will tell if its good or bad:");
    try
    {
        int num = Int32.Parse(Console.ReadLine());
        bool x = Test.NumCheck(num);
        Console.WriteLine($"Number is good:{x}");

    }
    catch (FormatException) { Console.WriteLine("Enter a NUMBER."); }

    
    

}




Console.ReadKey();




public class Sieve
{

    public checker NumCheck;



   
    public delegate bool checker(int num);
}















/* CHAPTER NOTES
int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
static int Count(int[] input, Func<int, bool> countFunction)
{
    int count = 0;
    foreach (int number in input)
        if (countFunction(number))
            count++;
    return count;
}



int count = Count(numbers, n => { return n % 2 == 0; });



*/