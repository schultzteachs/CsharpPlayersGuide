/*
 * The fourth pedestal demands constructing a door class with a locking mechanism that requires a unique
numeric code to unlock. You have done something similar before without using a class, but the locking
mechanism is new. The door should only unlock if the passcode is the right one. The following statements
describe how the door works.
• An open door can always be closed.
• A closed (but not locked) door can always be opened.
• A closed door can always be locked.
• A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if
the code supplied matches the door’s current passcode.
• When a door is created, it must be given an initial passcode.
• Additionally, you should be able to change the passcode by supplying the current code and a new
one. The passcode should only change if the correct, current code is given.
Objectives:
• Define a Door class that can keep track of whether it is locked, open, or closed.
• Make it so you can perform the four transitions defined above with methods.
• Build a constructor that requires the starting numeric passcode.
• Build a method that will allow you to change the passcode for an existing door by supplying the
current passcode and new passcode. Only change the passcode if the current passcode is correct.
• Make your main method ask the user for a starting passcode, then create a new Door instance. Allow
the user to attempt the four transitions described above (open, close, lock, unlock) and change the
code by typing in text commands
*/
string? Response = "";
//int? Guess = 0;
Door Door1 = new Door();
Console.WriteLine("Start the Door game?");
Response = Console.ReadLine();


if (Response == "y") {
    while (true)
    {
        Console.WriteLine("What would you like to do? Say Stop to stop loop.");

        Response = Console.ReadLine();

        if (Response == "Stop")
        {
            break;

        }
        if (Response == "Door") {
            Door1.CreateDoor();
            break; }

        if (Response == null) { Console.WriteLine("You gotta pick something..."); }

        if (Response == "Lock")
        {
            Door1.Lock();
        }
        if (Response == "Unlock")
        {
            Door1.Unlock();
        }
        if (Response == "Close")
        {
            Door1.Close();
        }
        if (Response == "Open")
        {
            Door1.Open();
        }
    }
}



public class Door
{
    public DoorState Current { get; set; } = DoorState.Closed;
    private DoorState LockedStatus { get; set; } = DoorState.Locked;

    private int Passcode = 0;

    static int guess = 0;

    static string Response = "";
    

    public void ChangePasscode()
    {
        Console.WriteLine("Would you like to change the Passode?");
        Response = Console.ReadLine() ;
        if (Response == "y")
        {
            Console.WriteLine("What should the new password be?");
            Response = Console.ReadLine();
            Passcode = Int32.Parse(Response);
            Response = " ";
            Console.WriteLine("Passcode changed.");
        }
        else { 
            Console.WriteLine("Moving on...");
            Response = " "; }

    }
    public void CreateDoor()
    {
        Console.WriteLine("You are attempting to create a new door.");
        new Door();
    }

    public Door()
    {
        Console.WriteLine("What will be the passcode for this door? (Use numbers only)");
        Passcode = Int32.Parse(Console.ReadLine());
        Console.Clear();   
    }

    public bool CheckPasscode(int Guess)
    {
       
        guess = Int32.Parse(Console.ReadLine());
        return Passcode == guess; 
    }

    public void Open()
    {
        if (Current == DoorState.Closed && LockedStatus == DoorState.Unlocked)
        {
            Current = DoorState.Open;
            Console.WriteLine("Door is opened.");
        }
        else if (Current == DoorState.Open)
        { Console.WriteLine("The door IS already open."); }
        else
        {
            Console.WriteLine("Door is locked and requires unlocking.");
            Console.WriteLine("Say Unlock to unlock.");
        }
    }
    public void Close()
    {
        if (Current == DoorState.Open)
        {
            Current = DoorState.Closed;
            Console.WriteLine("Door is closed. Use Lock to lock it.");
        }
        else if (Current == DoorState.Closed)
        {
            Console.WriteLine("Door is already closed. Use Lock to lock it.");
        }
        else { Console.WriteLine("Something isn't right..."); 
        }
    }
    

    public void Lock() 
    {
        if (Current == DoorState.Closed && LockedStatus == DoorState.Unlocked)
        {
            LockedStatus = DoorState.Locked;
            Console.WriteLine("Door is locked. I hope you know the passcode.");
            Console.WriteLine("Use Unlock to unlock door.");

        }
        else if (LockedStatus == DoorState.Locked)
        {
            Console.WriteLine("Door is already locked, bub.");
        }
        else if (Current == DoorState.Open)
        {
            Console.WriteLine("You need to close the door first by using the Close method.");
        }
        else
        {
            Console.WriteLine("Something is wrong...");
        }
    }
   

    public void Unlock() 
    {
        if (LockedStatus == DoorState.Locked)
        {
            Console.WriteLine("The door needs the passcode to be unlocked");
            Console.WriteLine("What is the passcode?");

            if (CheckPasscode(guess))
            {
                LockedStatus = DoorState.Unlocked;
                Console.WriteLine("Door is UNLOCKED!");
                ChangePasscode();
                
            }
            else
            {
                Console.WriteLine("Wrong Password.");
            }
        }
        else if (LockedStatus == DoorState.Unlocked)
        {
            Console.WriteLine("Door is already unlocked.");
        }
        else if (Current == DoorState.Open)
        {
            Console.WriteLine("You must close the door first by using the Close method.");
        }
        else
        {
            Console.WriteLine("Something went wrong...");
        }
    }
        }
            

    

public enum DoorState { Open, Closed, Locked, Unlocked }