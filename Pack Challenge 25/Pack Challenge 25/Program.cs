using System.Linq;

/* You know you have a long, dangerous journey ahead of you to travel to and repair the Fountain of
Objects. You decide to build some classes and objects to manage your inventory to prepare for the trip.
You decide to create a Pack class to help in holding your items. Each pack has three limits: the total
number of items it can hold, the weight it can carry, and the volume it can hold. Each item has a weight
and volume, and you must not overload a pack by adding too many items, too much weight, or too much
volume.
There are many item types that you might add to your inventory, each their own class in the inventory
system. 
Objectives:
• Create an InventoryItem class that represents any of the different item types. This class must
represent the item’s weight and volume, which it needs at creation time (constructor).
• Create derived classes for each of the types of items above. Each class should pass the correct weight
and volume to the base class constructor but should be creatable themselves with a parameterless
constructor (for example, new Rope() or new Sword()).
• //DONE Build a Pack class that can store an array of items. The total number of items, the maximum weight,
//and the maximum volume are provided at creation time and cannot change afterward.


/*DONE  Make a public bool Add(InventoryItem item) method to Pack that allows you to add items
of any type to the pack’s contents.This method should fail (return false and not modify the pack’s fields) if adding the item would cause it to exceed the pack’s item, weight, or volume limit. 


•

• DONE Add properties to Pack that allow it to report the current item count, weight, and volume, and the
limits of each.
•

Create a program that creates a new pack and then allow the user to add (or attempt to add) items
chosen from a menu.*/


Pack PlayerPack  = new Pack(10.0f, 15.0f, 3f);

while (true){

    Console.WriteLine("What would you like to add to the pack?");
    foreach (ItemMenu thing in Enum.GetValues(typeof(ItemMenu)))
    {
        Console.WriteLine(thing.ToString());
        
    }

    string addthis = Console.ReadLine();

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
        Water water= new Water();
        PlayerPack.Add(water);
    }
    else if (addthis == "FoodRations")
    {
        FoodRations food= new FoodRations();
        PlayerPack.Add(food);
    }
    else if (addthis == "Sword")
    {
        Sword sword = new Sword();
        PlayerPack.Add(sword);
    }

    //{ Arrow, Bow, Rope, Water, FoodRations, Sword}
    Console.WriteLine("The pack contains: ");
    foreach (var thing in PlayerPack.Items)
    {
        Console.WriteLine(thing.GetType()); 
    }
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
    private float PackVolume {  get; set; }

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
    public float Weight { get;}
    public float Volume { get;}
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

public class Arrow() : InventoryItem(0.1f, 0.05f);
public class Bow() : InventoryItem(1.0f, 4.0f);

public class Rope() : InventoryItem(1.0f, 1.5f);

public class Water() : InventoryItem(2.0f, 3.0f);

public class FoodRations() : InventoryItem(1.0f, 0.5f);

public class Sword() : InventoryItem(5.0f, 3.0f);
/*public class Arrow() : InventoryItem
{
    public float Weight = 0.1f;
    float Volume = 0.05f;
}

//(2) A bow has a weight of 1 and a volume of 4.

public class Bow() : InventoryItem
{
    float Weight = 0.1f;
    float Volume = 0.05f;
}
//(3) Rope has a weight of 1 and a volume of 1.5.
public class Rope() : InventoryItem
{
    float Weight = 1f;
    float Volume = 1.5f;
}
//(4) Water has a weight of 2 and a volume of 3.
public class Water() : InventoryItem
{
    float Weight = 2f;
    float Volume = 3f;
}
//(5) Food rations have a weight of 1 and a volume of 0.5.
public class FoodRations() : InventoryItem
{
    float Weight = 1f;
    float Volume = 0.5f;
}
//(6) A sword has a weight of 5 and a volume of 3.

public class Sword() : InventoryItem
{
    float Weight = 5;
    float Volume = 3;
}
*/

enum ItemMenu { Arrow, Bow, Rope, Water, FoodRations, Sword}