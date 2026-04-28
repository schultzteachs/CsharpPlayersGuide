// Create a two player game where 2 player pick numbers out of a list of 0 to 9. Pick a number before the game for the oatmeal cookie. If a player chooses that cookie, they lose and the other player wins. 
//When the oatmeal cookie is chosen, throw an Exception 
//Use List<int> to store numbers that are chosen, use the Contains method to see if a number has been used before





//start a new game


public class CookieGame()
{
    public bool PlayerOneTurn = true;
   
    public List<int> ChosenNum = new List<int>();

    public List<int> NumAvail = new List<int> { 0,1,2,3,4,5,6,7,8,9};

    private Random rnd = new Random();

    private int NastyOatmealCookie = 0;

    string? response = "";

    int choice = 0;



    public void StartGame()
    {
        NastyOatmealCookie = rnd.Next(10);
        try
        {
            Console.WriteLine("Who will go first? Say 1 or 2 and press enter");
            response = Console.ReadLine();
        }
        catch (Exception) {
            Console.WriteLine("Something was off. Player One will go first!");
            PlayerOneTurn = true;
        } 
        if (response == "1")
        {

        }
        if (response == "2")
        {

        }

        //Turn system
        //When a player makes a choice, check if already chosen in ChosenNumList using List.Contains

        //Chosen numbers should be removed from NumAvail and placed in Chosen Num List


       
        //Throw exception when oatmeal is chosen
        //At end of turn, player1 should equal player2  
    }




    

}