/*The digital Realms of C# have playing cards like ours but with some differences. Each card has a color
(red, green, blue, yellow) and a rank (the numbers 1 through 10, followed by the symbols $, %, ^, and &).
The third pedestal requires that you create a class to represent a card of this nature.
192 LEVEL 24 THE CATACOMBS OF THE CLASS
Objectives:
•DONE Define enumerations for card colors and card ranks. DONE
•DONE Define a Card class to represent a card with a color and a rank, as described above.
• Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a
face card).
• Create a main method that will create a card instance for the whole deck (every color with every
rank) and display each (for example, “The Red Ampersand” and “The Blue Seven”).
• Answer this question: Why do you think we used a color enumeration here but made a color class
in the previous challenge?
 * 
 * 
 */

Card.CreateDeck();


class Card
{
    public string Color { get; }
    public string Rank { get; }

    public string GetName()
    {
        return $"The {Color} {Rank}";
    }

    public static void CreateDeck()
    {
        foreach (Suit s in Enum.GetValues(typeof(Suit)))
        {
            foreach(Ranking r in Enum.GetValues(typeof(Ranking)))
            {

                Console.WriteLine($"The {s} {r}");
                new Card(s.ToString(), r.ToString());
            }
        }
    }

    public Card(string c, string r)
    {
        if (Enum.IsDefined(typeof(Suit),c)){
            Color = c;
        }
        else
        {
            Console.WriteLine("Not a valid suit!");
        }

        if ((Enum.IsDefined(typeof(Ranking), r)))
        {
            Rank = r;
        }
        else
        {
            Console.WriteLine("Not a valid number!");
        }
    }
   public enum Suit {Red, Green, Yellow, Blue }

   public enum Ranking { One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine ,Ten, DollarSign, PercentSign, UpperSand, AmperSand}

}