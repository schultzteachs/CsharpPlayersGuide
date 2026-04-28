
//34 Challenge - Better Random
//Write an extension for Random.NextDouble() to return a random number between 0 and another number



//Method for choosing between random strings: "up", "down", "left", "right"




//Coin toss sim method that returns bool with optional changes in probabilities 

public static class Challenge2
{
    public static double NextDouble(this Random random, double scale)
    {
        
        double result = random.NextDouble() * scale;
        return result;
    }

    public static string NextString(this Random random, params string[] directions)
    {
        int numItems = directions.Count();
        int pick = random.Next(numItems);
        return directions[pick];
    }

    public static bool CoinFlip(this Random random, double prob = 0.5)
    {
        bool result = random.NextDouble() < prob;
        return result;
    }
}





public class Challenge1
{

    public void NumberParser()
    {
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

    }
}