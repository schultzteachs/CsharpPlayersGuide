Color test2 = Color.Red;

Color test1 = new Color("Red");



Color test3 = new Color(255, 0, 0);

Console.WriteLine($"Values of the first custom color is:  R:{test1.R}, G:{test1.G}, B:{test1.B}");

Console.WriteLine($"Values of the second custom color is:  R:{test2.R}, G:{test2.G}, B:{test2.B}");
public class Color
{
    public int R { get;  }
    public int G { get;  }
    public int B { get; }

    
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    //static properties 
    public static Color Black { get; } = new Color(0, 0, 0);

    public static Color White { get; } = new Color(255, 255, 255);

    public static Color Red { get; } = new Color(255, 0, 0);

    public static Color Orange { get; } = new Color(255, 165, 0);

    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);

    public static Color Blue { get; } = new Color(0, 0, 255);

    public static Color Purple { get; } = new Color(128, 0, 128);
    public int[] GetColor()
    {
        return new int[] { R, G, B };
    }
 
    

    //if i give a string, set the rgb for me
    public Color(string color)
    {
        switch (color)
        {
            case "Black":
                R = 0;
                G = 0;
                B = 0;
                break;
            case "White":
                R = 255;
                G = 255;
                B = 255;
                break;
            case "Red":
                R = 255;
                G = 0;
                B = 0;
                break;
            case "Orange":
                R = 255;
                G = 165;
                B = 0;
                break;
            case "Yellow":
                R = 255;
                G = 255;
                B = 0;
                break;
            case "Green":
                R = 0;
                G = 128;
                B = 0;
                break;
            case "Blue":
                R = 0;
                G = 0;
                B = 255;
                break;
            case "Purple":
                R = 128;
                G = 0;
                B = 128;
                break;

        }
    }
}
