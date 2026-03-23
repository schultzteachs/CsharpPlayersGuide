using System;

public class DefenseConsola
{
	
	public void DefenseConsola()
	{

       public int TargetRow;
    public int TargetColumn;


        Console.WriteLine("Target Row?");
        TargetRow = int.Parse(Console.ReadLine());
        Console.WriteLine("Target Column?");
        TargetColumn = int.Parse(Console.ReadLine());



        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Deploy to:");

        Console.WriteLine($"{(TargetRow - 1)}, {(TargetColumn)}");
        Console.WriteLine($"{(TargetRow + 1)}, {(TargetColumn)}");
        Console.WriteLine($"{(TargetRow)}, {(TargetColumn - 1)}");
        Console.WriteLine($"{(TargetRow)}, {(TargetColumn + 1)}");
        Console.Beep();


    }
}
