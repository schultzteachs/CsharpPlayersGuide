/*
 *DONE Override the existing ToString method (from the object base class) on all of your inventory item
subclasses to give them a name. For example, new Rope().ToString() should return "Rope".
•DONE Override ToString on the Pack class to display the contents of the pack. If a pack contains water,
rope, and two arrows, then calling ToString on that Pack object could look like "Pack
containing Water Rope Arrow Arrow".
•DONE Before the user chooses the next item to add, display the pack’s current contents via its new
ToString method.
 * */

Pack PlayerPack = new Pack(10.0f, 15.0f, 3f);

while (true)
{

    Console.WriteLine("What would you like to add to the pack?");
    foreach (ItemMenu thing in Enum.GetValues(typeof(ItemMenu)))
    {
        Console.WriteLine(thing.ToString());

    }

    string? addthis = Console.ReadLine();

    if (addthis == "Arrow")
    {
        Arrow arrow = new Arrow();
        PlayerPack.Add(arrow);
    }
    else if (addthis == "Bow")
    {
        Bow bow = new Bow();
        PlayerPack.Add(bow);
    }

    else if (addthis == "Rope")
    {
        Rope rope = new Rope();
        PlayerPack.Add(rope);
    }

    else if (addthis == "Water")
    {
        Water water = new Water();
        PlayerPack.Add(water);
    }
    else if (addthis == "FoodRations")
    {
        FoodRations food = new FoodRations();
        PlayerPack.Add(food);
    }
    else if (addthis == "Sword")
    {
        Sword sword = new Sword();
        PlayerPack.Add(sword);
    }

    //HERE
    Console.WriteLine(PlayerPack.ToString());
    
    Console.WriteLine("\n");

    //Console.WriteLine($"The pack contains {PlayerPack.Items}");

    //string PackCount = Int32.Parse(PlayerPack.TotalItems);
    Console.WriteLine($"The pack's item count is {PlayerPack.Items.Count}");
    Console.WriteLine($"The pack's weight is currently {PlayerPack.PackWeight}");

}

public class Pack
{

    public List<InventoryItem> Items = new();


    private float MaxWeight { get; set; }
    private float MaxVolume { get; set; }

    private float ItemCount { get; set; }

    private float MaxItemCount { get; set; }

    public float PackWeight { get; set; }
    private float PackVolume { get; set; }

    public Pack(float maxWeight, float maxVolume, float maxItemCount)
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        MaxItemCount = maxItemCount;

    }
    public float TotalItems()
    {

        return Items.Count;
    }

    public override string ToString()
    {
        string saying = "";
        foreach (var thing in Items)
        {
            saying = saying + " " + thing.ToString();
        }
        return $"Pack contains {saying}";
    }
    public bool Add(InventoryItem item)
    {

        //weight volume count check
        if (PackWeight + item.Weight > MaxWeight || PackVolume + item.Volume > MaxVolume || ItemCount >= MaxItemCount)
        {
            Console.WriteLine("TOO MUCH!");
            return false;
        }
        else
        {
            PackWeight = PackWeight + item.Weight;
            PackVolume += item.Volume;
            ItemCount += 1;
            Items.Add(item);
            return true;
        }

    }
}


public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }
    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
    public InventoryItem()
    {
        this.Weight = 0;
        this.Volume = 0;
    }
}

//(1) An arrow has a weight of 0.1 and a volume of 0.05.

public class Arrow() : InventoryItem(0.1f, 0.05f)
{
    public override string ToString()
    {
        return "Arrow";
    }
}
public class Bow() : InventoryItem(1.0f, 4.0f)
{
    public override string ToString()
    {
        return "Bow'";
    }
}

public class Rope() : InventoryItem(1.0f, 1.5f)
{
    public override string ToString()
    {
        return "Rope";
    }
}

public class Water() : InventoryItem(2.0f, 3.0f)
{
    public override string ToString()
    {
        return "Water";
    }
}

public class FoodRations() : InventoryItem(1.0f, 0.5f)
{
    public override string ToString()
    {
        return "Food";
    }
}

public class Sword() : InventoryItem(5.0f, 3.0f)
    {
    public override string ToString()
    {
        return "Sword";
    }
}

enum ItemMenu { Arrow, Bow, Rope, Water, FoodRations, Sword }