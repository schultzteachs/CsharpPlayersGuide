//not done
using System.Drawing;

Sword swordy = new Sword();
Bow bow = new Bow();
Axe axe = new Axe();



ColoredItems<Bow> RedBow = new ColoredItems<Bow>(bow, ConsoleColor.Red);
ColoredItems<Sword> BlueSword = new ColoredItems<Sword> (swordy, ConsoleColor.Blue);
ColoredItems<Axe> GreenAxe = new ColoredItems<Axe>(axe, ConsoleColor.Green);

//Testing
RedBow.Display();
BlueSword.Display();
GreenAxe.Display();




//Generics and Class setups


public class ColoredItems<T> 
{
    public T item;

    public ConsoleColor color = new ConsoleColor();

    public ColoredItems(T itemname, ConsoleColor newcolor){
        item = itemname;
        color = newcolor;
        }
    public void Display()
    {
        Console.BackgroundColor = color;
        Console.WriteLine(item.ToString());
        Console.ResetColor();
    }
   
}



public class Sword { }
public class Bow { }
public class Axe{ }


