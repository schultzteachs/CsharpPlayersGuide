
//34 Challenge - Better Random
//Write an extension for Random.NextDouble() to return a random number between 0 and another number



//Method for choosing between random strings: "up", "down", "left", "right"




//Coin toss sim method that returns bool with optional changes in probabilities 












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