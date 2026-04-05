MainMethod();

 void MainMethod()
{
    
    Console.WriteLine("Here are the choices: North, West, South, East, On, Off.");
    Console.WriteLine("What would you like the robot to do? Enter 3 ");
    Robot newRobot = new Robot();

    for (int i = 0; i < newRobot.Commands.Count; i++)
    {
        string response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "north":
                    newRobot.Commands[i] = new NorthCommand();
                    break;
                case "west":
                    newRobot.Commands[i] = new WestCommand();
                    break;
                case "south":
                    newRobot.Commands[i] = new SouthCommand();
                    break;
                case "east":
                    newRobot.Commands[i] = new EastCommand();
                    break;
                case "on":
                    newRobot.Commands[i] = new OnCommand();
                    break;
                case "off":
                    newRobot.Commands[i] = new OffCommand();
                    break;
            }
      }

   newRobot.Run();


}


public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    
    public List<IRobotCommand> Commands = new List<IRobotCommand>();
    //old, array way
    //public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
     public abstract void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }

}
public class OffCommand : IRobotCommand
{
    public void Run(Robot robot) 
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y++;

        }
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X++;
        }
    }
}
public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y--;
        }
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X--;
        }
    }
}