

CharberryTree tree = new CharberryTree();

Notifier notifier = new Notifier(tree);

Harvester harvester = new Harvester(tree);

while (true)
    tree.MaybeGrow();


public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }

    public event EventHandler? Ripened;
    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
          
            Ripened?.Invoke(this, EventArgs.Empty );
        }
    }
}

public class Notifier 
{
    public Notifier(CharberryTree tree)
    {
        tree.Ripened += OnTreeRipened;
    }


    private void OnTreeRipened(object? sender, EventArgs e)
    {
        Console.WriteLine("A charberry fruit has ripened!");
       
    }
    
}
public class Harvester
{
    private CharberryTree _tree;
    public Harvester(CharberryTree tree)
    {
        _tree = tree;
        _tree.Ripened += Harvest;
    }
    public void Harvest(object? sender, EventArgs e)
    {
        _tree.Ripe = false;
        Console.WriteLine("The charberry was harvested.");

    }
}


/*
public class Ship
{
    public event Action? ShipExploded;
    public int Health { get; private set; }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0)
            ShipExploded.Invoke();
    }
    
    private List<IExplosionHandler> _handlers = new List<IExplosionHandler>();

    public void AddExplosionHandler(IExplosionHandler newHandler) => _handlers.Add(newHandler);

    private void TellHandlersAboutExplosion()
    {
        foreach (IExplosionHandler hander in _handlers)
            hander.HandleShipExploded();
    }
}

public class SoundEffectManager
{
    private void OnShipExploded() => PlaySound("Explosion");

    public SoundEffectManager(Ship ship)
    {
        ship.ShipExploded += OnShipExploded;
    }
    public void PlaySound(string name)
    {

    }
}

public interface IExplosionHandler
{
    void HandleShipExploded();
}

*/