// Create a two player game where 2 player pick numbers out of a list of 0 to 9. Pick a number before the game for the oatmeal cookie. If a player chooses that cookie, they lose and the other player wins. 
//When the oatmeal cookie is chosen, throw an Exception 
//Use List<int> to store numbers that are chosen, use the Contains method to see if a number has been used before



CookieGame start = new CookieGame();

start.StartGame();


//start a new game


public class CookieGame()
{
    public bool PlayerOneTurn = true;
   
    public List<int> ChosenNum = new List<int>();

    public List<int> NumAvail = new List<int> {0,1,2,3,4,5,6,7,8,9};

    public Random rnd = new Random();

    public int NastyOatmealCookie  = 2;
        
    

    string? response = "";

    int choice = 0;

    private bool GameOn = false;


 


    public void StartGame()
    {
        NastyOatmealCookie = rnd.Next(10);
        
        try
        {
            
            Console.WriteLine("Who will go first? Say 1 or 2 and press enter");
            response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("Ok. Player One will go first!");
                PlayerOneTurn = true;
                GameOn = true;
            }
            if (response == "2")
            {
                Console.WriteLine("Ok. Player Two will go first!");
                PlayerOneTurn = false;
                GameOn = true;
            }
        }
        catch (Exception) {
            Console.WriteLine("Something was off. Player One will go first!");
            PlayerOneTurn = true;
            GameOn = true;
        } 


        
        while (GameOn)
        {
            Console.WriteLine("Pick a number! 0 to 9 and one that has not been chosen...");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (NumAvail.Contains(choice))
                {
                    NumAvail.Remove(choice);
                    ChosenNum.Add(choice);
                    PlayerOneTurn = !PlayerOneTurn;
                }
                else if (!(NumAvail.Contains(choice)))
                {
                    Console.WriteLine("That number has been chosen. Pick another...");
                }
                else
                {
                    Console.WriteLine("Something went wrong... let's try again...");
                }

                if (choice == NastyOatmealCookie)
                {
                    GameOn = false;
                    throw new NastyException();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Your choice needs to be a number!");
            }
            catch (NastyException)
            {
                switch (PlayerOneTurn)
                {
                    case true: Console.WriteLine("Player One Wins!"); Console.WriteLine("Dear Player Two,"); break;
                    case false: Console.WriteLine("Player Two Wins!"); Console.WriteLine("Dear Player One,"); break;
                }
                Console.Write("You get the nasty oatmeal cookie. gg");
            }
            
        }
        Console.ReadKey();
    }

    public class NastyException() : Exception
    {
        

    }



}