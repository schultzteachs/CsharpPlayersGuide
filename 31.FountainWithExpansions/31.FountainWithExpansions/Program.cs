


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
        newGame.TimeKeeper.StartTime();//here to start time
        
        while (newGame.GameOn == true)
        {
            newGame.Update();
        }
        if (newGame.GameOn != true)
        {
            TimeSpan time = newGame.TimeKeeper.GetTimeElapsed();
            Console.WriteLine($"Time elapsed: {time.TotalSeconds}");
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
    public int[,] board = new int[4, 4];
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
                else { WallMessage(); }
                break;
            case "east":
                if (X < 3) { X++; }
                else { WallMessage(); }
                break;
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
    public TimeKeeper TimeKeeper = new TimeKeeper();
    public int[] PlayerPos = [0, 0];
    private bool Winnable = false;
    public bool GameOn = true;
    private int[] PitLoca = [0, 2];
    private int[] AmaLoca = [3, 2];


    //DONE - Add UI for rooms

    public void Update()
    {
        //this needs to be the game loop
        Console.WriteLine($"---------------------------------------------------------");
        Console.WriteLine($"You, {Player.Name}, are at location, Row:{Player.Y} Col:{Player.X}");
        RoomUI(PlayerPos);
        PitRoom();
        AmarokRoom();
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
                //here to stop time
                this.TimeKeeper.EndTime();
                Console.WriteLine("It took you ");
            }
            else
            {
                Console.WriteLine("You need to enable the fountain before leaving!");
            }

        }
    }
    private void PitRoom()
    {
        if (PlayerPos[0] == PitLoca[0] && PlayerPos[1] == PitLoca[1])
        {
            GameOn = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You fell into the pit!");
            Console.ResetColor();
            this.TimeKeeper.EndTime();
            return; 
        }
        int xDistance = Math.Abs(PlayerPos[0] - PitLoca[0]);
        int yDistance = Math.Abs(PlayerPos[1] - PitLoca[1]);

        if (xDistance <= 1 && yDistance <= 1)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Be careful! You sense the pit room close...");
            Console.ResetColor();
        }

    }
    private void AmarokRoom()
    {
        int AmaRoomX = AmaLoca[0];
        int AmaRoomY = AmaLoca[1];
        if (PlayerPos[0] == AmaLoca[0] && PlayerPos[1] == AmaLoca[1])
        {
            GameOn = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You were eaten by the Amarok!");
            Console.ResetColor();
            this.TimeKeeper.EndTime();
            return;
        }
        int xDistance = Math.Abs(PlayerPos[0] - AmaLoca[0]);
        int yDistance = Math.Abs(PlayerPos[1] - AmaLoca[1]);

        if (xDistance <= 1 && yDistance <= 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Be careful! You smell the stench of an Amarok...");
            Console.ResetColor();
        }
    
    }
    
}

public record TimeKeeper
{
    public DateTime starttime { get; set; }
    public DateTime finishTime { get; set; }
    public DateTime StartTime()
    {
        starttime = DateTime.Now;
        return starttime;

    }
    public DateTime EndTime()
    {
        finishTime = DateTime.Now;
        return finishTime;
    }
    public TimeSpan GetTimeElapsed()
    {
        return (finishTime - starttime);
    }
}
