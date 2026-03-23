



Console.WriteLine("*______Welcome to the Arrow Shop______*");
Console.WriteLine("Choose your Arrow head");
Console.WriteLine($"{ArrowType.Steel} {ArrowType.Wood} {ArrowType.Obsidian}");
string arrowheadchosen = Console.ReadLine();
float headCost = 1;
if (arrowheadchosen == "steel")
{
    headCost = 10;
}
if (arrowheadchosen == "wood")
{
    headCost = 3;
}
if (arrowheadchosen == "obsidian")
{
    headCost = 5; 
}
Console.WriteLine("Choose your Fletching Type");
Console.WriteLine($"{FletchingType.Plastic}, {FletchingType.TurkeyFeather}, {FletchingType.GooseFeather}");
string fletchingchosen = Console.ReadLine();
float fletchingCost = 1;
if (fletchingchosen == "plastic")
{
    fletchingCost = 10;
}
if (fletchingchosen == "turkeyfeather")
{
    fletchingCost = 5;
}
if (fletchingchosen == "goosefeather")
{
    fletchingCost = 3;
}

Console.WriteLine("How long do you need the arrow? Pick a number between 60 and 100");
float lengthchosen = Int32.Parse(Console.ReadLine());
float lengthcost = lengthchosen * 0.05f;

Arrow Chosen = new Arrow();
if ((arrowheadchosen != null) && (lengthchosen != 0) && (fletchingchosen != null))
{
    Console.WriteLine("The cost for your new arrow is:");
    Console.WriteLine(Chosen.GetCost(headCost, fletchingCost, lengthchosen));
}
else
{
    Console.WriteLine("Something went wrong...");
}

class Arrow
{
    public string arrowhead;
    public string fletching;
    public float length;

   public int SteelCost = 10;
   public int WoodCost = 3;
   public int ObsidianCost = 5;
   public int PlasticCost = 10;
   public int TurkeyCost = 5;
   public int GooseCost = 3;
   public float Length = 60f;
   public float LengthCost => 0.05f * Length;

   public float GetHeadCost = 0f;

    public void SetArrowHead(string arrowheadchosen) {
        if (arrowheadchosen == "steel")
        {
            GetHeadCost = 10;
        }
        if (arrowheadchosen == "wood")
        {
            GetHeadCost = 3;
        }
        if (arrowheadchosen == "obsidian")
        {
            GetHeadCost = 5;
        }
    }
   public float GetCost(float a,  float b, float c )
    {
    return a + b + c;
    }
  
}

//Menu for arrows
enum ArrowType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }
