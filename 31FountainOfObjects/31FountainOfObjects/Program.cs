

NewGame();
void NewGame()
{
    Console.WriteLine("Would you like to unlock the fountain of objects? Press y and enter");
    string response = Console.ReadLine();
    if (response == "y")
    {
        
        Console.WriteLine("New game starting!");
        Board GameBoard = new Board();
        GameManager newGame = new GameManager();
        newGame.GameOn = true;
        Console.WriteLine($"Welcome, {newGame.Player.Name}!");
        
        while (newGame.GameOn == true)
        {
            newGame.Update();
        }
    }
    else
    {
        Console.WriteLine("Bye.");
    }
}




//Board
public struct Board
{
    public int[,]board = new int[4,4];
    public bool OutOfBounds = false;

   
    public Board()
    {
       
    }
}



//Player

public class Player
{
    public int Y = 0;
    public int X = 0;
    public string Name = " ";


    public void Move(string direction) 
    {
    
            switch (direction.ToLower())
            {

            case "north":
                if (Y < 3) { Y++; }
                else { WallMessage();} break;
                case "east":
                if (X < 3) { X++; }
                else { WallMessage(); } break;
                case "south":
                if (Y > 0) { Y--; }
                else { WallMessage(); }
                break;
            case "west":
                if (X > 0) { X--; }
                else { WallMessage(); }
                break;

        }
       
       
    }

public void WallMessage()
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("There is a wall that way. Pick another direction.");
    Console.ResetColor();
}
    public Player()
    {
        Console.WriteLine("What is your name? Press enter when done.");
        string name = Console.ReadLine();
        Name = name;
        
        
    }
    
}



//Game Manager

public class GameManager
{
    public GameManager() { }
    
    public Board Gameboard = new Board();
    public Player Player = new Player();
    public int[] PlayerPos = [0, 0];
    private bool Winnable = false;
    public bool GameOn = true;


    //DONE - Add UI for rooms
    
    public void Update()
    {
        //this needs to be the game loop
        Console.WriteLine($"---------------------------------------------------------");
        Console.WriteLine($"You, {Player.Name}, are at location, Row:{Player.Y} Col:{Player.X}");
        RoomUI(PlayerPos);
        if (GameOn)
        {
            Console.WriteLine("Which direction would you like to move?");
            string response = Console.ReadLine();
            Player.Move(response);
            PlayerPos = [Player.X, Player.Y];
        }
        
    }

    public void RoomUI(int[] pos)
    {
        
        switch (pos)
        {
            case [0, 0]: Console.WriteLine("You see light in this room coming from outside the cavern. You are at the entrance"); Entrance(); break;
            case [2, 0]: Console.WriteLine("“You hear water dripping in this room. The Fountain of Objects is here!”"); Fountain(); break;
            default: Console.WriteLine("It is dark in this room."); break;
        }
    }
    private void Fountain()
    {
        Console.WriteLine("The Fountain of Objects is before you. Would you like to enable? Type y.");
        string? response = Console.ReadLine();
        if (response == "y")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fountain ENABLED");
            Winnable = true;
            Console.ResetColor();
            Console.WriteLine("Return to the entrance to exit and win.");

        }
    
    }
    private void Entrance()
    {
        Console.WriteLine("You see the exit. Would you like to leave?");
        string? response = Console.ReadLine();
        if (response == "y")
        {
            if (Winnable)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("YOU WIN!");
                System.Console.Beep();
                Console.ResetColor();
                this.GameOn = false;

            }
            else
            {
                Console.WriteLine("You need to enable the fountain before leaving!");
            }

        }
    }
}