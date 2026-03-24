int i = 0;
while (Goblin.TotalGoblins < 6)
{
    Console.WriteLine($"There are {Goblin.TotalGoblins} in the Goblin Army");
    Console.WriteLine("..... adding one more.");
    Goblin poopy = new Goblin();
    i++;
}

class Armor
{
    public string name;
    public int defense;

}

class Player
{
    private int _health;
    public int health
    {
        get => _health;
        set
        {
            if (value < 0 ) _health = 0;
            else if (value > 100) _health = 100;
            else _health = value;
        }
    }

    private string _name;
    public string name
    {
        get;
        set;
    }



}


class Goblin
{
    public static int TotalGoblins = 0;


    public Goblin()
    {
        TotalGoblins++;
    }
}