
Console.WriteLine("*______Welcome to the Arrow Shop______*");
Console.WriteLine("Choose your Arrow head");
Console.WriteLine($"{ArrowType.Steel} {ArrowType.Wood} {ArrowType.Obsidian}");

BetterArrow purchase = new BetterArrow();
purchase.arrowhead = Console.ReadLine();
Console.WriteLine("Choose your Fletching Type");
Console.WriteLine($"{FletchingType.Plastic}, {FletchingType.TurkeyFeather}, {FletchingType.GooseFeather}");
purchase.fletching = Console.ReadLine();
Console.WriteLine("How long do you need the arrow? Pick a number between 60 and 100");
purchase.length = Int32.Parse(Console.ReadLine());


Console.WriteLine($"You have purchased an arrow with {purchase.arrowhead} arrowhead, {purchase.fletching} fletching, and {purchase.length}cm long.");
public class BetterArrow
{
    public string arrowhead { get; set; } = " ";
    public string fletching { get; set; } = " ";

    private float _length;
    public float length {
        get => _length;
        set
        {
            if (value < 60) _length = 60f;
            else if (value > 100) _length = 100f;
            else _length = value;
        } 
    }



}





//Menu for arrows
enum ArrowType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }