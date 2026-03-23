Chest Status = Chest.Locked;


while (true){

    Console.WriteLine($"The chest is {Status}. What do you want to do?");
    string Switch = Console.ReadLine();

   
    if (Switch == "open")
    {
        Status = Chest.Open;
    }
    else if (Switch == "close")
    {
        Status = Chest.Closed;
    }
    else if (Switch == "lock")
    {
        Status = Chest.Locked;
    }
    else if (Switch != null)
    {
        Console.WriteLine("Wrong Answer");
    }


}
enum Chest {Open,Closed,Locked};