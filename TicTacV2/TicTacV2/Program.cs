

GameManager Game1 = new GameManager();
Game1.PlayGame();


//Game1.PlaceX(2);


public class Board
{

    public string[] GameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    //Keep track of board state
    public Board()
    { }

    public void Display()
    {
        Console.WriteLine($" {GameBoard[0]} | {GameBoard[1]} | {GameBoard[2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GameBoard[3]} | {GameBoard[4]} | {GameBoard[5]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GameBoard[6]} | {GameBoard[7]} | {GameBoard[8]}");
    }
    public void PlaceX(int placement)
    {
        GameBoard[placement] = "X";
    }
    public void PlaceO(int placement)
    {
        GameBoard[placement] = "O";

    }

}



public class Player
{
    //public Choices Choices;
    //public Players PlayerNum;
    //Player #
    //Player Sym
    public string _Sym { get; set; } = " ";
    private string _Num { get; set; } = " ";

    public Player(string Num, string Sym)
    {

        string _Num = Num;
        string _Sym = Sym;
    }
    public Player() { _Num = " "; _Sym = " "; }





}

public class GameManager
{
    private Board _currentBoard = new Board();
    public string? NewGame = " ";
    Player Player1 = new Player();
    Player Player2 = new Player();


    //GameManager uses composition to "own" the board so all related methods write on it
    public GameManager()
    {
        _currentBoard = new Board();
    }
    //Begins Game... Maybe?
    public void PlayGame()
    {
        //setup
        Console.WriteLine("New game? Press y then Enter");
        NewGame = Console.ReadLine();
        if (NewGame == "y")
        {
            Console.WriteLine("Player One will go first. Would you like to be X or O?");
            string? Player1Sym = Console.ReadLine();
            
            string? Player2Sym = Console.ReadLine();
            
            //Player Player1 = new Player("One", "Player1Sym");
            //Player Player2 = new Player("Two", "Player2Sym");
            if (Player1Sym == "X")
            {
                Console.WriteLine("Okay! Player Two will be O! Let's begin");
                Player2Sym = "O";

            }
            else if (Player1Sym == "O")
            {
                Console.WriteLine("Okay! Player Two will be X! Let's begin");
                Player2Sym = "X";
            }
            else
            {
                Console.WriteLine("Something went wrong but I will make Player One X. Let's begin!");
                Player2Sym = "O";
            }
            //game loop
            while (true)
            {
                _currentBoard.Display();
                Console.WriteLine("Player One, which square would you like to write in?");
                int BoardPlacement = Int32.Parse(Console.ReadLine());
                BoardPlacement = BoardPlacement - 1;

                if (_currentBoard.GameBoard[BoardPlacement] == "O" || _currentBoard.GameBoard[BoardPlacement] == "X")
                {
                    Console.WriteLine("That spot is taken! Try again!");
                }
                else
                {
                    if (Player1Sym == "X")
                    {
                        _currentBoard.PlaceX(BoardPlacement);
                    }
                    if (Player1Sym == "O")
                    {
                        _currentBoard.PlaceO(BoardPlacement);
                    }

                    _currentBoard.Display();
                    if (GameOverCheck(_currentBoard) == true)
                    {

                        _currentBoard.Display();
                        Console.WriteLine("Game Over!");
                        break;
                    }
                    Console.WriteLine("Player Two, which square would you like to write in?");
                    BoardPlacement = Int32.Parse(Console.ReadLine());
                    BoardPlacement = BoardPlacement - 1;
                    if (Player2Sym == "X")
                    {
                        _currentBoard.PlaceX(BoardPlacement);
                    }
                    if (Player2Sym == "O")
                    {
                        _currentBoard.PlaceO(BoardPlacement);
                    }

                }

                if (GameOverCheck(_currentBoard) == true)
               {

                    _currentBoard.Display();
                    Console.WriteLine("Game Over!");
                    break;
                }

            }


        }

    }


    //Decides game over
    private bool GameOverCheck(Board _currentBoard)
    {
        int count = 0;
        //board is full
        foreach (string spot in _currentBoard.GameBoard)
        {

            if (spot == "O" || spot == "X")
            {
                count++;
            }
            if (count == 9)
            {
                return true;
            }
        }

        //str8 across
        if (_currentBoard.GameBoard[0] == _currentBoard.GameBoard[1] && _currentBoard.GameBoard[1] == _currentBoard.GameBoard[2])
        {

            return true;
        }
        if (_currentBoard.GameBoard[3] == _currentBoard.GameBoard[4] && _currentBoard.GameBoard[4] == _currentBoard.GameBoard[5])
        {

            return true;
        }
        if (_currentBoard.GameBoard[6] == _currentBoard.GameBoard[7] && _currentBoard.GameBoard[7] == _currentBoard.GameBoard[8])
        {

            return true;
        }


        //str8 down
        if (_currentBoard.GameBoard[0] == _currentBoard.GameBoard[3] && _currentBoard.GameBoard[3] == _currentBoard.GameBoard[6])
        {

            return true;
        }
        else if (_currentBoard.GameBoard[1] == _currentBoard.GameBoard[4] && _currentBoard.GameBoard[4] == _currentBoard.GameBoard[7])
        {

            return true;
        }
        else if (_currentBoard.GameBoard[2] == _currentBoard.GameBoard[5] && _currentBoard.GameBoard[5] == _currentBoard.GameBoard[8])
        {

            return true;
        }
        //diagonal 
        else if (_currentBoard.GameBoard[0] == _currentBoard.GameBoard[4] && _currentBoard.GameBoard[4] == _currentBoard.GameBoard[8])
        {

            return true;
        }
        else if (_currentBoard.GameBoard[6] == _currentBoard.GameBoard[4] && _currentBoard.GameBoard[4] == _currentBoard.GameBoard[2])
        {

            return true;
        }
        else
        {
            return false;
        }

    }


}




//Announces Winner/Game Over!

