

Point A = new Point(6, 7);

A.ToString();

Point B = new Point(6, 7);

Console.WriteLine(A.ToString());
Console.WriteLine(B.ToString());
Console.WriteLine(A == B); //returns True

//Deconstruction
(float x, float y) = A;

//with Statements
Point p1 = new Point(6, 7);
Point p2 = p1 with { X = 0 };

Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

Console.WriteLine("_________________Challenge Below This Line__________________________");


Sword orginal = new Sword(Material.iron, null, 100, 20);
Sword upgradeLvl1 = orginal with { gem = Gemstone.amber };
Sword upggradeLvl2 = upgradeLvl1 with { material = Material.steel}; 

Console.WriteLine(upggradeLvl2.ToString());
Console.WriteLine(upgradeLvl1.ToString());


Console.WriteLine(orginal);


public record Point(float X, float Y);

public record Sword(Material material, Gemstone? gem, int Length, int CrossguardWidth );

public enum Material{ wood, bronze, iron, steel, binarium};

public enum Gemstone { emerald, amber, sapphire, diamond, bitstone}


